using formpractice.Data;
using formpractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace formpractice.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Show the registration form
        public IActionResult CreateUser()
        {
            return View();
        }

        // POST: Register a new user
        [HttpPost]
        [ValidateAntiForgeryToken]  // Protects against CSRF attacks
        public async Task<IActionResult> CreateUser(User model)
        {
            if (ModelState.IsValid)
            {
                // Check if the email already exists in the database
                if (await _db.Users.AnyAsync(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "This email is already registered.");
                    return View(model);  // Return to the same view with validation error
                }

                // Hash the password before saving
                var hashedPassword = HashPassword(model.Password);

                // Create a new user object
                var user = new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    Password = hashedPassword
                };

                // Save the new user to the database
                _db.Users.Add(user);
                await _db.SaveChangesAsync();

                // Redirect to a different page
                return RedirectToAction("Viewuser");
            }

            // If validation fails, return the same view with errors
            return View(model);
        }

        // Simple password hashing method (SHA256 in this case)
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        // View all users (for example, to view the registered users)
        public async Task<IActionResult> Viewuser()
        {
            var users = await _db.Users.ToListAsync();
            return View(users); // Passing list of users to the view
        }

        public IActionResult Notfound()
        {
            return View();
        }

        public async Task<IActionResult> delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Notfound");
            }

            var dta = await _db.Users.FindAsync(id);

            if (dta != null)
            {
                _db.Remove(dta);
                await _db.SaveChangesAsync();
                return RedirectToAction("Viewuser");
            }
            return RedirectToAction("Notfound");
        }

        // GET: Edit user
        public async Task<IActionResult> edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Notfound");
            }
            var dta = await _db.Users.FindAsync(id);

            if (dta == null)
            {
                return RedirectToAction("Notfound");
            }
            return View(dta);
        }

        // POST: Edit user
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> edit(int id, [Bind("Id, Name, Email, Password")] User dta)
        {
            if (id != dta.Id)
            {
                return RedirectToAction("Notfound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // If password is changed, hash it again
                    if (!string.IsNullOrEmpty(dta.Password))
                    {
                        dta.Password = HashPassword(dta.Password);
                    }

                    _db.Update(dta);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Handle concurrency issue (e.g., data might have changed in the meantime)
                    ModelState.AddModelError("", "Concurrency error: The user may have been updated by another process.");
                    return View(dta);
                }
                return RedirectToAction("Viewuser");
            }

            return View(dta);
        }
    }
}
