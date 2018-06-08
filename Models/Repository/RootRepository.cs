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
            var root = _context.Roots.FirstOrDefault(r => r.Id == id);

            return root;
        }

        public long Add(RootModel newRoot)
        {
            _context.Roots.Add(newRoot);
            long rootId = _context.SaveChanges();

            return rootId;
        }

        public long Update(long id, RootModel rootItem)
        {
            long rootId = 0;
            var root = _context.Roots.Find(id);

            if (root != null)
            {
                root.RootName = rootItem.RootName;

                rootId = _context.SaveChanges();
            }

            return rootId;
        }

        public long Delete(long id)
        {
            int rootId = 0;
            var root = _context.Roots.FirstOrDefault(r => r.Id == id);

            if (root != null)
            {
                _context.Roots.Remove(root);
                rootId = _context.SaveChanges();
            }

            return rootId;
        }
    }
}