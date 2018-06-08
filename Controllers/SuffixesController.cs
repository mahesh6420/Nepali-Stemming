using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stemming.Controllers.Interface;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
    [Route("api/[controller]")]
    public class SuffixesController : Controller, ICrudInterface<SuffixModel>
    {
        public readonly IDataRepostory<SuffixModel, long> _suffixRepo;

        public SuffixesController(IDataRepostory<SuffixModel, long> suffixRepo)
        {
            _suffixRepo = suffixRepo;
        }
        
        [HttpGet]
        public IEnumerable<SuffixModel> Get()
        {
            return _suffixRepo.GetAll();
        }

        [HttpGet("{id}")]
        public SuffixModel Get(int id)
        {
            return _suffixRepo.Get(id);
        }

        [HttpPost]
        public void Post(SuffixModel newItem)
        {
            _suffixRepo.Add(newItem);
        }

        [HttpDelete]
        public long Delete(int id)
        {
           return _suffixRepo.Delete(id);
        }

        [HttpPut]
        public void Put(SuffixModel item)
        {
            _suffixRepo.Update(item.Id, item);
        }
    }
}