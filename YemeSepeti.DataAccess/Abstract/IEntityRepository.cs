using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Abstract;

namespace YemeSepeti.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);   

        T Get(Expression<Func <T,bool>> filter=null);
        void Add(T entity); 
        void Delete(T entity);  
        void Update(T entity);
    }
}
