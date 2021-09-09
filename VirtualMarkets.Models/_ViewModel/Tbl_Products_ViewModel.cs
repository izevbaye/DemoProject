﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DemoProject.Models.Department;

namespace DemoProject.Models._ViewModel
{
    public class Tbl_Products_ViewModel
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Product_Name { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Tbl_Departments_Category Tbl_Departments_Category { get; set; }

        [ForeignKey("ProductID")]
        public Tbl_Products_BulkPurchase Tbl_Products_BulkPurchase { get; set; }
        public DateTime EntryDate { get; set; }
        public string Product_Code { get; set; }
        public string Description_Short { get; set; }
        public string Description_Long { get; set; }
        [Required]
        public decimal Price_Unit { get; set; }
        public decimal? Price_Advert { get; set; }
        public bool Stock { get; set; }

        public string Tag_Description_One { get; set; }

        public string Tag_Description_Two { get; set; }
        public bool IsEnabled { get; set; }
    }
    //public class Tbl_Products_ViewModel
    //{
    //    [Key]
    //    public int ProductID { get; set; }

    //    public string Product_Name { get; set; }
    //    // public string SubCategory_name { get; set; }
    //    public Tbl_Departments_Category Tbl_Departments_Category { get; set; }


    //    public string Description_Long { get; set; }

    //    public string Description_Short { get; set; }

    //    public decimal Price_Unit { get; set; }

    //}
}
