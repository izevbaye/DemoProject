using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Web.Pages.Admin.Projects
{
    public class DeleteModel : PageModel
    {
        private readonly MyDataContext _context;

        public DeleteModel(MyDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tbl_Products Tbl_Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

       //     Tbl_Products = await _context.Tbl_Products
        //        .Include(t => t.Tbl_Departments_Category).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Tbl_Products == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tbl_Products = await _context.Tbl_Products.FindAsync(id);

            if (Tbl_Products != null)
            {
                _context.Tbl_Products.Remove(Tbl_Products);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
