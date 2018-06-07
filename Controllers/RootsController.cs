using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
//    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RootsController : Controller
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
    }
}