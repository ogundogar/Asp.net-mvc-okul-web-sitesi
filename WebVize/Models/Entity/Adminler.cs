using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebVize.Models.Entity
{
    
    public class Adminler
    {
        [Key]
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

    }
}