using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebVize.Models.Entity
{
    public class DuyurularDal
    {
        public List<Duyurular> DuyuruGetAll()
        {
            using (UniDbContext context = new UniDbContext())
            {
                return context.Duyurular_.ToList();
            }

        }

        public void Duyuru_Add(Duyurular duyurular)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(duyurular);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Duyuru_Update(Duyurular duyurular)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(duyurular);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Duyuru_Delete(Duyurular duyurular)
        {
            using (UniDbContext context = new UniDbContext())
            {
                var entity = context.Entry(duyurular);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}