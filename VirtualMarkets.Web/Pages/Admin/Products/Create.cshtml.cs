using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoProject.Models.Department;
using DemoProject.DataContext;

namespace DemoProject.Web.Pages.Admin.Projects
{
    public class CreateModel : PageModel
    {
        private readonly MyDataContext _context;

        public CreateModel(MyDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryID"] = new SelectList(_context.Set<Tbl_Departments_Category>(), "CategoryID", "CategoryID");
            return Page();
        }

        [BindProperty]
        public Tbl_Products Tbl_Products { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tbl_Products.Add(Tbl_Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
