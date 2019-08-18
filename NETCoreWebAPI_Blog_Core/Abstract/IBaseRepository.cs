using NETCoreWebAPI_Blog_DB.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreWebAPI_Blog_Core.Abstract
{
    public interface IBaseRepository<TEntity>
        where TEntity : class, IEntity
    {
        Task<TEntity> GetById(int Id);
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
        IQueryable<TEntity> GetAll();
       
    }
}
