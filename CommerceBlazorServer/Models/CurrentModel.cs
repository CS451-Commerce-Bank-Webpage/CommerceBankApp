using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommerceBlazorServer.Models
{
    public class CurrentModel
    {
        [Required]
        [Compare(nameof(dbUsername), ErrorMessage = "Username Doesn't Exist...")]
        public string UserName { get; set; }
        [Required]
        [Compare(nameof(dbPassword), ErrorMessage ="Wrong password...")]
        public string Password { get; set; }

        public string dbUsername { get; set; }

        public string dbPassword { get; set; }

    }
}
