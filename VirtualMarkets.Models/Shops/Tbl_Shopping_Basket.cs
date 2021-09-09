using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Models.Department;

namespace DemoProject.Models.Shops
{
    public class Tbl_Shopping_Basket
    {
        [Key]
        public int BasketID { get; set; }

        public string ASPNetID { get; set; }
        [Required]
        public string Username { get; set; }

     
        [Required]
        
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Tbl_Products Tbl_Products { get; set; }

            public int BasketID_Active { get; set; }

        public DateTime Dates { get; set; }

        public Guid UniqueID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price_Unit { get; set; }

        public decimal Total { get; set; }

        public bool Discount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsCompleted { get; set; }

      //  public Products products { get; set; }

        public decimal Basket_Total
        {
            get { return Quantity * Price_Unit; }
            // set { Basket_Total = Basket_Total; }
        }
        public decimal Invoice
        {
            get { return Quantity * Price_Unit; }
            // set { Basket_Total = Basket_Total; }
        }
    }
}
