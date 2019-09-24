using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2019.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [StringLength(150)]
        public string Address { get; set; }


        [DataType(DataType.Date)]
        [Required]
        public DateTime DateofBirth { get; set; }


        [Url]
        public string Url { get; set; }

    }
}
