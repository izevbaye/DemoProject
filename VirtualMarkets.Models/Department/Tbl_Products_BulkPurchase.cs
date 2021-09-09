using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoProject.Models.Department
{
    public class Tbl_Products_BulkPurchase
    {
        [Key]
        public int BulkPurchaseID { get; set; }
        [Required]
        public string BP_Name { get; set; }
      //  [ForeignKey("BulkPurchaseID")]
        public int FK_ProductID { get; set; }
        [Required]
        public string BP_Offer { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Description_Short { get; set; }

        public string Description_Long { get; set; }
        public decimal Price_Unit { get; set; }
        public int Min_Purchase { get; set; }
        public int Max_Purchase { get; set; }

        public bool IsExpire { get; set; }
        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }
    }
}
