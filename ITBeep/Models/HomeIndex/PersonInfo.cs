using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITBeep.Models.HomeIndex
{
    public class PersonInfo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="الاسم")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^((00962|\\+962|0)?)(7)[0-9]{8}$", ErrorMessage ="Please enter valid phone number.")]
        [Display(Name = "الهاتف")]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "الايميل")]
        public string Email { get; set; }
    }
}