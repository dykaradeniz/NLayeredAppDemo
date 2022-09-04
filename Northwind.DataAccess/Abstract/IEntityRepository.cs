using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Func<T,bool> filter=null); //kullanıcı isterse filtre vermek zorunda değil
        T Get(Func<T, bool> filter); // ister idye ister isme göre vb get etsin diye değişken bıraktık
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}