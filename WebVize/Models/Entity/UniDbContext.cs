using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVize.Models.Entity
{
    public class UniDbContext: System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Duyurular> Duyurular_ { get; set; }
        public System.Data.Entity.DbSet<Adminler> Adminler_ { get; set; }
    }
}
