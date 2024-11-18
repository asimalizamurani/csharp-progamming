using Microsoft.AspNetCore.Mvc;
using Handlingform.Models;  // Ensure to import your models
using System.Linq;
using System.Threading.Tasks;
using Handlingform.Data;
using Microsoft.EntityFrameworkCore;


public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context) // TODO: Inject ApplicationDbContext into controller
    {
        _context = context;
    }

    // GET: /User/Register
    public IActionResult Register()
    {
        return View(); // Return the registration view
    }

    // POST: /User/Register
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(User user)
    {
        if (ModelState.IsValid) // TODO: Check if model state is valid
        {
            // Check if the email already exists in the database
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == user.Email);

            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "This email is already taken.");
                return View(user); // Return the form with error message
            }

            // TODO: Hash the password before saving (for security reasons)
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password); // Assuming you use BCrypt for hashing

            // Save the user to the database
            _context.Add(user); // Add the user to the context
            await _context.SaveChangesAsync(); // Save changes to the database

            return RedirectToAction("Index", "Home"); // Redirect to Home or login page after successful registration
        }

        return View(user); // If model state is invalid, return the view with validation errors
    }
}
