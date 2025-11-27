using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Store21WebApplication.Models;

namespace Store21WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Store21WebApplication.Data.StoreContext _context;

        public string UserRole { get; set; }
        public string UserName { get; set; }

        public IndexModel(Store21WebApplication.Data.StoreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task<IActionResult> OnGet()
        {
            UserRole = HttpContext.Session.GetString("UserRole");

            if (string.IsNullOrWhiteSpace(UserRole))
                return RedirectToPage("Login");

            Product = await _context.Products
                .Include(p => p.Manufacturer)
                .Include(p => p.Provider).ToListAsync();

            UserName = HttpContext.Session.GetString("UserName");
            return Page();
        }

        public async Task<IActionResult> OnPostLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("./Index");
        }
    }
}
