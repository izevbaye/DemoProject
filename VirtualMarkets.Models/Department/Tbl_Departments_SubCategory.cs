using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoProject.Models.Department
{
    class Tbl_Departments_SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }              // This is the PK

        //  [ForeignKey("DepartmentID")]
        public int CategoryID { get; set; } // this is a FK
        [ForeignKey("CategoryID")]
        public Tbl_Departments_Category Tbl_Departments_Category { get; set; }


        //  [ForeignKey("SubCategoryID")]
        //   public Products Products { get; set; }
        public string SubCategory_Name { get; set; }
        public string Property_One { get; set; }
        public string Property_Two { get; set; }
        public string Property_Three { get; set; }
        public DateTime EntryDate { get; set; }
        public string Description_Short { get; set; }
        public string Description_Detailed { get; set; }
        public string Notes { get; set; }
        // public string Reference { get; set; }
        public Guid UniqueId { get; set; }
        public bool IsEnabled { get; set; }

        public List<Tbl_Products> Tbl_Products { get; set; }
        public int ProductCount { get; set; }
    }
}
