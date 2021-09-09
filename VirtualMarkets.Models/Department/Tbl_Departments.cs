using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.Models.Department
{
    public class Tbl_Departments
    {
      
            [Key]
            public int DepartmentID { get; set; }
            //[Display(Name ="Department_Name")]
            [Required]
            [StringLength(150, ErrorMessage = "First name cannot be longer than 150 characters.")]
            public string Department_Name { get; set; }
            //[Display(Name ="Department_Long")]
            [Required]
            public string Description_Long { get; set; }
            //[Display(Name ="Short Description_Short")]
            [Required]
            [StringLength(150, ErrorMessage = "First name cannot be longer than 150 characters.")]
            public string Description_Short { get; set; }
            public bool IsEnabled { get; set; }




            [ForeignKey("CategoryID")]
          // public Departments_Departments Departments_Departments { get; set; }
            public List<Tbl_Departments_Category> Tbl_Departments_Category { get; set; }
            public int ProductCount { get; set; }
      
    }
}
