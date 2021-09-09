using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoProject.DataContext;
using DemoProject.Models.Department;

namespace DemoProject.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly DemoProject.DataContext.MyDataContext _context;
       // private int ehi;
        //private string ehi;

        //public IndexModel(string ehi)
        //{
        //    this.ehi = ehi;
        //}

        public IndexModel(DemoProject.DataContext.MyDataContext context)
        {
            _context = context;
        }

        public IList<Tbl_Products> Tbl_Products { get;set; }

        public async Task OnGetAsync()
        {
            

            Tbl_Products = await _context.Tbl_Products
            //  .Include(m => m.Tbl_Departments_Category)
                     .Where(r => r.IsEnabled).Select(u => new Tbl_Products
                     {
                         ProductID = u.ProductID,
                         Product_Name = u.Product_Name,
                         Description_Long = u.Description_Long,
                         Description_Short = u.Description_Short,
                      //   ProductCount = u.Tbl_Departments_Category.Count()





                     })

              .ToListAsync();
        }
    }
}
