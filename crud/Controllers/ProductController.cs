using formpractice.Data;
using formpractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace formpractice.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Create a new product
        public IActionResult Create()
        {
            return View();
        }

        // POST: Add a new product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model)
        {
            if (ModelState.IsValid)
            {
                // Handle image upload
                if (model.Image != null)
                {
                    // Generate a unique file name for the image
                    var fileName = Path.GetFileNameWithoutExtension(model.Image.FileName) + "_" + Guid.NewGuid().ToString() + Path.GetExtension(model.Image.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    // Save the image file
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(fileStream);
                    }

                    // Set the ImagePath property to the saved file path
                    model.ImagePath = "/images/" + fileName;
                }

                // Add the product to the database using the lowercase 'product'
                _db.product.Add(model);  // 'product' is lowercase
                await _db.SaveChangesAsync();

                return RedirectToAction("Viewproduct"); // Redirect to the 'Viewproduct' action to list all products
            }

            return View(model); // If validation fails, return the same view with errors
        }

        // View all products (for displaying all added products)
        public async Task<IActionResult> Viewproduct()
        {
            var products = await _db.product.ToListAsync();  // 'product' is lowercase
            return View(products); // Passing list of products to the view
        }
    }
}
