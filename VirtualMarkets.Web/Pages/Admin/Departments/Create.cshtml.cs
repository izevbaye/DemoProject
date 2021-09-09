using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoProject.Models.Department;
using DemoProject.DataContext;

namespace DemoProject.Web.Pages.Admin.Departments
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
            return Page();
        }

        [BindProperty]
        public Tbl_Departments Tbl_Departments { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tbl_Departments.Add(Tbl_Departments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
