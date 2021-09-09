using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.Models.Department;
using DemoProject.DataContext;

namespace DemoProject.Web.Pages.Admin.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly MyDataContext _context;

        public DetailsModel(MyDataContext context)
        {
            _context = context;
        }

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
    }
}
