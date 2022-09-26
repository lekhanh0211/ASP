using EProject_Sem3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.BLL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private Eproject_DbContext ctx;
        private DbSet<T> tbl;
        public Repository()
        {
            ctx = new Eproject_DbContext();
            tbl = ctx.Set<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                tbl.Add(entity);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Check(Expression<Func<T, bool>> predicate)
        {
            return tbl.AsNoTracking().Any(predicate);
        }

        public bool Edit(T entity)
        {
            try
            {
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> Get()
        {
            return tbl.AsNoTracking().AsEnumerable();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return tbl.Where(predicate).AsEnumerable();
        }

        public T Get(object id)
        {
            return tbl.Find(id);
        }

        public bool Remove(object id)
        {
            try
            {
                var entity = Get(id);
                tbl.Remove(entity);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
