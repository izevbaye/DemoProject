using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoProject.Models.Shops.Work
{
    public class Work_Shopping_Basket
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Username { get; set; }
    }
    public class W_S_Basket_Update
    {
        [Required]
        public int BasketID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Username { get; set; }
    }

    public class W_S_Basket_Delete
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        
        public string Username { get; set; }
    }
    public class Shops
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        public string Quantity { get; set; }
    }
}
