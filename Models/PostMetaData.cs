using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class PostMetaData
    {
            public int Id { get; set; }
        public string uid { get; set; }
        [Required(ErrorMessage = "Enter Title ")]
        public string title { get; set; }
        [Required(ErrorMessage = "Write Some Text ")]
        public string discrition { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> likes { get; set; }
    
    }
}