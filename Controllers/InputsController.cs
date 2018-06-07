using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
    [Route("api/[controller]")]
    public class InputsController : Controller
    {
        private readonly IDataRepostory<InputModel, long> _inputRepo;

        public InputsController(IDataRepostory<InputModel, long> inputRepo)
        {
            _inputRepo = inputRepo;
        }

        [HttpGet]
        public IEnumerable<InputModel> Get()
        {
            return _inputRepo.GetAll();
        }
    }
}