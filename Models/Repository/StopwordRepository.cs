using System.Collections.Generic;
using System.Linq;
using Stemming.Models.Interface;

namespace Stemming.Models.Repository
{
    public class StopwordRepository : IDataRepostory<StopWordModel, long>
    {
        private DatabaseContext _context;

        public StopwordRepository(DatabaseContext context)
        {
            _context = context;
        }
        
        public IEnumerable<StopWordModel> GetAll()
        {
            return _context.Stopwords.ToList();
        }

        public StopWordModel Get(long id)
        {
            var stopword = _context.Stopwords.FirstOrDefault(s => s.Id == id);

            return stopword;

        }

        public long Add(StopWordModel newStopword)
        {
            _context.Stopwords.Add(newStopword);
            long stopwordId = _context.SaveChanges();

            return stopwordId;
        }

        public long Update(long id, StopWordModel stopwordModel)
        {
            var stopwordId = 0;
            var stopword = _context.Stopwords.Find(id);

            if (stopword != null)
            {
                stopword.StopWord = stopwordModel.StopWord;
                stopwordId = _context.SaveChanges();
            }

            return stopwordId;
        }

        public long Delete(long id)
        {
            var stopwordId = 0;
            var stopword = _context.Stopwords.Find(id);

            if (stopword != null)
            {
                _context.Stopwords.Remove(stopword);

                stopwordId = _context.SaveChanges();
            }

            return stopwordId;
        }
        
    }
}
