using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.Models.Department;
using DemoProject.DataContext;

namespace DemoProject.Web.Pages.Admin.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly MyDataContext _context;

        public DetailsModel(MyDataContext context)
        {
            _context = context;
        }

        public Tbl_Products Tbl_Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
//
         //   Tbl_Products = await _context.Tbl_Products
       //         .Include(t => t.Tbl_Departments_Category).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Tbl_Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
