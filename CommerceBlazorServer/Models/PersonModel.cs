using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CommerceBlazorServer.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(9, ErrorMessage = "Account number is too long.")]
        [MinLength(9, ErrorMessage = "Account number is too short.")]
        public string account_id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Password is too long.")]
        [MinLength(9, ErrorMessage = "Password is too short.")]
        public string password { get; set; }
        [Compare(nameof(password), ErrorMessage ="Passwords do not match!")]
        public string passwordConfirm { get; set; }

        public string processing_date { get; set; }
       
        public int balance { get; set; }
        [Required]
        public string security_question { get; set; }
        [Required]
        public string security_answer { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
        public string location { get; set; }
        public string description{ get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Username is too long.")]
        [MinLength(5, ErrorMessage = "Username is too short.")]
        public string username { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public DateTime date { get; set; }
    }
}