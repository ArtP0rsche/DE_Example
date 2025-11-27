using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store21WebApplication.Data;
using Store21WebApplication.Models;

namespace Store21WebApplication.Pages
{
    public class LoginModel : PageModel
    {
        private readonly Store21WebApplication.Data.StoreContext _context;

        public LoginModel(Store21WebApplication.Data.StoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostLoginAsync()
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == User.Login);

            if (user != null && user.Password == User.Password)
            {
                HttpContext.Session.SetString("UserRole", user.Role);
                HttpContext.Session.SetString("UserName", user.Fullname);
                return RedirectToPage("./Index");
            }

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostGuestAsync()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("UserRole", "Guest");
            return RedirectToPage("./Index");
        }
    }
}
