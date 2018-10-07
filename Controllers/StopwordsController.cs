using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Stemming.Controllers.Interface;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
    [Route("api/[controller]")]   
    [EnableCors("AllowSpecificOrigin")]
    public class StopwordsController : Controller, ICrudInterface<StopWordModel>
    {
        public readonly IDataRepostory<StopWordModel, long> _stopwordRepo;

        public StopwordsController(IDataRepostory<StopWordModel, long> stopwordRepo)
        {
            _stopwordRepo = stopwordRepo;
        }

        [HttpGet]
        public IEnumerable<StopWordModel> Get()
        {
            return _stopwordRepo.GetAll();
        }

        [HttpGet("{id}")]
        public StopWordModel Get(int id)
        {
            return _stopwordRepo.Get(id);
        }

        [HttpPost]
        public void Post(StopWordModel newItem)
        {
            _stopwordRepo.Add(newItem);
        }

        [HttpDelete]
        public long Delete(int id)
        {
            return _stopwordRepo.Delete(id);
        }

        [HttpPut]
        public void Put(StopWordModel item)
        {
            _stopwordRepo.Update(item.Id, item);
        }
    }
}
