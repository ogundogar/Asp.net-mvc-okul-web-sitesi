using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebVize.Models.Entity
{
    public class AdminlerDal
    {
        public List<Adminler> AdminGetAll()
        {
            using (UniDbContext context= new UniDbContext())
            {
                return context.Adminler_.ToList();
            }
            
        }

        public void Admin_Add(Adminler adminler)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(adminler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Admin_Update(Adminler adminler)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(adminler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Admin_Delete(Adminler adminler)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(adminler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}