using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Web.Pages.Admin.Departments
{
    public class ManagerModel : PageModel
    {

        private readonly MyDataContext _context;

        public ManagerModel(MyDataContext context)
        {
            _context = context;
        }

        public IList<Tbl_Departments> Tbl_Departments { get; set; }

        public async Task OnGetAsync()
        {

            Tbl_Departments = await _context.Tbl_Departments.Include(m => m.Tbl_Departments_Category)
                       .Where(r => r.IsEnabled).Select(u => new Tbl_Departments
                       {
                           DepartmentID = u.DepartmentID,
                           Department_Name = u.Department_Name,
                           Description_Long = u.Description_Long,
                           Description_Short = u.Description_Short,
                           ProductCount = u.Tbl_Departments_Category.Count()



                       })
                
                
                .ToListAsync();
        }
    }
}
