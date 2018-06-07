using System.Collections.Generic;
using System.Linq;
using Stemming.Models.Interface;

namespace Stemming.Models.Repository
{
    public class RootRepository : IDataRepostory<RootModel, long>
    {
        private DatabaseContext _context;

        public RootRepository(DatabaseContext context)
        {
            _context = context;
        }
        
        public IEnumerable<RootModel> GetAll()
        {
            var roots = _context.Roots.ToList();

            return roots;
        }

        public RootModel Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public long Add(RootModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Update(long id, RootModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}