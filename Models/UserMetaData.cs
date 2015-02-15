using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class UserMetaData 
    {
        [Required(ErrorMessage="Enter Username")]
        public string username { get; set; }
        
        [Required(ErrorMessage="Enter Password")]
        public string password { get; set; }
        
        [Required(ErrorMessage = "Enter Full Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Valid Email")]//[Required(ErrorMessage = "Enter Valid Email")]
        public string email { get; set; }
        
        [Required(ErrorMessage = "Enter Phone")]
        public string phone { get; set; }

        [RegularExpression("[0-3][0-9]/[0-1][0-2]/[1][9][8-9][0-9]", ErrorMessage = "Follow 01/01/0001 Pattern")]
        public System.DateTime dob { get; set; }

        [Required(ErrorMessage = "Enter Profession")]
        public string profession { get; set; }

        public System.DateTime first { get; set; }
        
    }
}