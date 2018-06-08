using System.Collections.Generic;
using System.Linq;
using Stemming.Models.Interface;

namespace Stemming.Models.Repository
{
    public class SuffixRepository : IDataRepostory<SuffixModel, long>
    {
        private DatabaseContext _context;

        public SuffixRepository(DatabaseContext context)
        {
            _context = context;
        }
        
        public IEnumerable<SuffixModel> GetAll()
        {
            return _context.Suffixes.ToList();
        }

        public SuffixModel Get(long id)
        {
            var suffix = _context.Suffixes.FirstOrDefault(s => s.Id == id);

            return suffix;
        }

        public long Add(SuffixModel newSuffix)
        {
            _context.Suffixes.Add(newSuffix);
            long suffixId = _context.SaveChanges();

            return suffixId;
        }

        public long Update(long id, SuffixModel suffixItem)
        {
            long suffixId = 0;
            var suffix = _context.Suffixes.Find(id);

            if (suffix != null)
            {
                suffix.SuffixName = suffixItem.SuffixName;

                suffixId = _context.SaveChanges();
            }
            
            return suffixId;
        }

        public long Delete(long id)
        {
            long suffixId = 0;
            var suffix = _context.Suffixes.FirstOrDefault(s => s.Id == id);
            if (suffix != null)
            {
                _context.Suffixes.Remove(suffix);
                suffixId = _context.SaveChanges();
            }

            return suffixId;
        }
    }
}