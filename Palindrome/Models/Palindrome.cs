using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeMVCApp.Models
{
    public class Palindrome
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string InputWord { get; set; }

        public string RevWord { get; set; }
        public bool IsPalindrome { get; set; }
        public string Message { get; set; }
    }
}
