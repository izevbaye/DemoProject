using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Models.Department;

namespace DemoProject.Models.Shops
{
    public class Tbl_Shop_Discounts_BulkBuy
    {
        [Key]
        public int BulkBuyID { get; set; }
        public string BB_Name { get; set; }

        [ForeignKey("Tbl_Departments_Category")]
        public int CategoryID { get; set; }
        public Guid UniqueID { get; set; }
        public DateTime Date_Start { get; set; }
        public DateTime BDate_End { get; set; }
        public decimal Price_Unit { get; set; }

        public string Description_Short { get; set; }

        public string Description_Long { get; set; }
        public int Purchase_Minimum  { get; set; }

        public int Purchase_Maximum { get; set; }

        public bool IsEnabled { get; set; }

        public Tbl_Departments_Category Tbl_Departments_Category { get; set; }
    }
}
