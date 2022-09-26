using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.BLL.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate); //lấy theo id
        bool Check(Expression<Func<T, bool>> predicate);         //ktra theo đk
        T Get(object id);
        bool Add(T entity);
        bool Edit(T entity);
        bool Remove(object id);
    }
}
