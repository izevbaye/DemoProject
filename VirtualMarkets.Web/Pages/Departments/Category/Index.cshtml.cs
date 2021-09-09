using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Web.Pages.Departments.Category
{
    public class IndexModel : PageModel
    {
        private readonly DemoProject.DataContext.MyDataContext _context;

        public IndexModel(DemoProject.DataContext.MyDataContext context)
        {
            _context = context;
        }

        public IList<Tbl_Departments_Category> Tbl_Departments_Category { get;set; }

        public async Task OnGetAsync()
        {
            //Tbl_Departments_Category = await _context.Tbl_Departments_Category
            //    .Include(t => t.Tbl_Departments).ToListAsync();


            Tbl_Departments_Category = await _context.Tbl_Departments_Category
            .Include(m => m.Tbl_Departments)
                   .Where(r => r.IsEnabled).Select(u => new Tbl_Departments_Category
                   {
                       CategoryID = u.CategoryID,
                       Category_Name = u.Category_Name,
                       Description_Long = u.Description_Long,
                       Description_Short = u.Description_Short,
                       //     ProductCount = u.Tbl_Departments.Count()





                     })

            .ToListAsync();
        }
    }
}
