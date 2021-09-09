using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoProject.Models.Work.Shops
{
    public class Shopping_Delete_Cart
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string UserName { get; set; }

        
        public string Authentication { get; set; }
    }
}
