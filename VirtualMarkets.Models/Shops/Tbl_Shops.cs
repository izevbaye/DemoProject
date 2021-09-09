using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models.Shops
{
    public class Tbl_Shops
    {
        [Key]
        public int ShopID { get; set; }

        public string Shop_Name { get; set; }
    }
}
