using System.Collections.Generic;
using Stemming.Models.Interface;

namespace Stemming.Models.Repository
{
    public class StopwordRepository : IDataRepostory<StopWordModel, long>
    {
        public IEnumerable<StopWordModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public StopWordModel Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public long Add(StopWordModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Update(long id, StopWordModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new System.NotImplementedException();
        }
        
        
    }
}