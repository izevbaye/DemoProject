using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoProject.Models.Security
{
    public class Security_Authentication
    {
        [Required]
        public string IP { get; set; }

        [Required]
        public string Authentication { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}
