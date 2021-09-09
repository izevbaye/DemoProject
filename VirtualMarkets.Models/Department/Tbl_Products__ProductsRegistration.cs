using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoProject.Models.Department
{
   public class Tbl_Products__ProductsRegistration
    {
        [Key]
        public int RegistrationID { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Product Name cannot be longer than 200 characters.")]
        public int Product_Name { get; set; }
        public int CategoryID { get; set; }

        [StringLength(200, ErrorMessage = "Short Description cannot be longer than 200 characters.")]
        public string Description_Short { get; set; }
        public string Description_Long { get; set; }
        public DateTime Entry_Date { get; set; }

        public bool IsEnabled { get; set; }


        [ForeignKey("CategoryID")]
        public Tbl_Departments_Category Tbl_Departments_Category { get; set; }
    }
}

