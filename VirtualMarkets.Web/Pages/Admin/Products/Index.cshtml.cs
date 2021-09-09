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
    public class IndexModel : PageModel
    {
        private readonly MyDataContext _context;

        public IndexModel(MyDataContext context)
        {
            _context = context;
        }

        public IList<Tbl_Products> Tbl_Products { get;set; }

        public async Task OnGetAsync()
        {
         //   Tbl_Products = await _context.Tbl_Products
          //      .Include(t => t.Tbl_Departments_Category
                
              //  ).ToListAsync();
        }
    }
}
