using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models.Shops
{
    public class Tbl_Shops_Basket_Add
    {
        [Key]
        [Required]
        public int ProductID { get; set; }
        public string Username { get; set; }

        //public int DiscountID { get; set; }
        //  public DateTime Dates { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
