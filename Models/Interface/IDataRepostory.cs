using System.Collections.Generic;

namespace Stemming.Models.Interface
{
    public interface IDataRepostory<TEntity, U> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(U id);
        long Add(TEntity b);
        long Update(U id, TEntity b);
        long Delete(U id);
    }
}