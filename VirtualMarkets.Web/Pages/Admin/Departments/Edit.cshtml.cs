using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Web.Pages.Admin.Departments
{
    public class EditModel : PageModel
    {
        private readonly MyDataContext _context;

        public EditModel(MyDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tbl_Departments Tbl_Departments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tbl_Departments = await _context.Tbl_Departments.FirstOrDefaultAsync(m => m.DepartmentID == id);

            if (Tbl_Departments == null)
            {
                return NotFound();
            }
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

            _context.Attach(Tbl_Departments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tbl_DepartmentsExists(Tbl_Departments.DepartmentID))
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

        private bool Tbl_DepartmentsExists(int id)
        {
            return _context.Tbl_Departments.Any(e => e.DepartmentID == id);
        }
    }
}
