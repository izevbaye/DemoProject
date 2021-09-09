using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Models.Department;
using DemoProject.Models.Shops;

namespace DemoProject.DataContext
{
    public class MyDataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public readonly object Tbl_Users_Accounts_Address;

        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options) { }

        // public DbSet<Departments> Departments { get; set; }
        //public DbSet<Tbl_Products> Tbl_Products { get; set; }

        //public DbSet<Tbl_Products___Cart> Tbl_Products___Cart { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DemoProject;Integrated Security=True;MultipleActiveResultSets=true");
            //    optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1,9589;Initial Catalog=DemoProject;User ID='@desuw@_bebs2';Password='|ove*71';MultipleActiveResultSets=true");
        }


        public DbSet<DemoProject.Models.Department.Tbl_Departments> Tbl_Departments { get; set; }


        public DbSet<DemoProject.Models.Department.Tbl_Departments_Category> Tbl_Departments_Category { get; set; }


        //  public DbSet<DemoProject.Models.Department.Tbl_Departments_Category> Tbl_Departments_Category { get; set; }


        public DbSet<DemoProject.Models.Shops.Tbl_Shopping_Basket> Tbl_Shopping_Basket { get; set; }


        //  public DbSet<DemoProject.Models.Department.Tbl_Departments_Category> Tbl_Departments_Category { get; set; }


        public DbSet<DemoProject.Models.Department.Tbl_Departments2> Tbl_Departments2 { get; set; }
        public IEnumerable Tbl_Users { get; set; }
       // public object Tbl_Products { get; set; }
       public DbSet<Tbl_Products> Tbl_Products { get; set; }

     //   public DbSet<Tbl_Departments_Category> Tbl_Departments_Category { get; set; }
        // public DbSet<DemoProject.Models.Department.Tbl_Products> Products { get; set; }


        //  public DbSet<Tbl_Shopping_Basket> Tbl_Shopping_Basket { get; set; }


        //public DbSet<Tbl_Users> Tbl_Users { get; set; }
        //public DbSet<Tbl_Users_Accounts> Tbl_Users_Accounts { get; set; }

        //public DbSet<Tbl_Users_Accounts_Address> Tbl_Users_Accounts_Address { get; set; }
    }
}
