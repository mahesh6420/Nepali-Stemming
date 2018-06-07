using System.Collections.Generic;
using System.Linq;
using Stemming.Models.Interface;

namespace Stemming.Models.Repository
{
    public class InputRepository : IDataRepostory<InputModel, long>
    {
        private DatabaseContext _context;

        public InputRepository(DatabaseContext context)
        {
            _context = context;
        }
        
        public IEnumerable<InputModel> GetAll()
        {
            var inputs = _context.Inputs.ToList();

            return inputs;
        }

        public InputModel Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public long Add(InputModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Update(long id, InputModel b)
        {
            throw new System.NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}