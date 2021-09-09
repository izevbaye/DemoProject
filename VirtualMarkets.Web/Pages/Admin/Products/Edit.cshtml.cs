using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoProject.Models.Department;
using DemoProject.DataContext;

namespace DemoProject.Web.Pages.Admin.Projects
{
    public class EditModel : PageModel
    {
        private readonly MyDataContext _context;

        public EditModel(MyDataContext context)
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

         //   Tbl_Products = await _context.Tbl_Products
         //       .Include(t => t.Tbl_Departments_Category).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Tbl_Products == null)
            {
                return NotFound();
            }
           ViewData["CategoryID"] = new SelectList(_context.Set<Tbl_Departments_Category>(), "CategoryID", "CategoryID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tbl_Products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tbl_ProductsExists(Tbl_Products.ProductID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Tbl_ProductsExists(int id)
        {
            return _context.Tbl_Products.Any(e => e.ProductID == id);
        }
    }
}
