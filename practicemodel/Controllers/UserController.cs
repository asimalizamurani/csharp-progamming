using Microsoft.AspNetCore.Mvc;
using practicemodel.Data;  // Namespace where your ApplicationDbContext is located
using System.Linq;          // For LINQ ToList() method
using practicemodel.Models; // Namespace where your User model is located (if different)

namespace practicemodel.Controllers
{
    public class UserController : Controller
    {
        // Declare the private readonly field for ApplicationDbContext
        private readonly ApplicationDb _db;

        // Constructor with dependency injection for ApplicationDbContext
        public UserController(ApplicationDb db)
        {
            _db = db;
        }

        // Action to display the list of users
        public IActionResult User()
        {
            // Retrieve all users from the database
            var users = _db.Users.ToList();

            // Pass the users to the view
            return View(users);
        }

        // You can add more actions here, like Register, Edit, Delete, etc.
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }

   
}

