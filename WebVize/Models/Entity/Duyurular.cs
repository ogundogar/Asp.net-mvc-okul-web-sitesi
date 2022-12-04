using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebVize.Models.Entity
{
    public class Duyurular
    {
        [Key]
        public int DuyuruID { get; set; }
        public string DuyuruBasligi { get; set; }
        public string Duyuru { get; set; }
        public DateTime DuyuruTarih { get; set; }

    }
}