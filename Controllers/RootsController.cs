using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stemming.Controllers.Interface;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
//    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class RootsController : Controller, ICrudInterface<RootModel>
    {
        private readonly IDataRepostory<RootModel, long> _rootRepo;

        public RootsController(IDataRepostory<RootModel, long> rootRepo)
        {
            _rootRepo = rootRepo;
        }

        [HttpGet]
        public IEnumerable<RootModel> Get()
        {
            return _rootRepo.GetAll();
        }

        [HttpGet("{id}")]
        public RootModel Get(int id)
        {
            return _rootRepo.Get(id);
        }
        
        [HttpPost]
        public void Post([FromBody]RootModel newRootItem)
        {
            _rootRepo.Add(newRootItem);
        }
        
        [HttpDelete]
        public long Delete(int id)
        {
            return _rootRepo.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody]RootModel rootItem)
        {
            _rootRepo.Update(rootItem.Id, rootItem);
        }
    }
}