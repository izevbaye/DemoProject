using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoProject.Models.Department
{
   public class Tbl_Departments_Category
    {
      



            [Key]
            public int CategoryID { get; set; }              // This is the PK


            public int DepartmentID { get; set; } // this is a FK

            [ForeignKey("DepartmentID")]
            public Tbl_Departments Tbl_Departments { get; set; }

       // [ForeignKey("ProductID")]//
       // [ForeignKey("CategoryID")]
        //    public List<Tbl_Products> Tbl_Products { get; set; }
        
        public int ProductCount { get; set; }



        public int Count { get; set; }
            public string Category_Name { get; set; }
            public DateTime EntryDate { get; set; }
            public string Description_Short { get; set; }
            public string Description_Long { get; set; }
            public string Notes { get; set; }
            public string Reference { get; set; }
            public Guid UniqueId { get; set; }
            public bool IsEnabled { get; set; }




            

       
    }
}
