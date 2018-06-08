using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stemming.Models;

namespace Stemming.Controllers.Interface
{
    public interface ICrudInterface<TEntity> where TEntity: class 
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Post(TEntity newItem);
        long Delete(int id);
        void Put(TEntity item);
    }
}
