using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stemming.Controllers.Interface;
using Stemming.Models;
using Stemming.Models.Interface;

namespace Stemming.Controllers
{
    [Route("api/[controller]")]
    public class InputsController : Controller, ICrudInterface<InputModel>
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

        [HttpGet("{id}")]
        public InputModel Get(int id)
        {
            return _inputRepo.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] InputModel newItem)
        {
            _inputRepo.Add(newItem);
        }

        [HttpDelete]
        public long Delete(int id)
        {
            return _inputRepo.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] InputModel item)
        {
            _inputRepo.Update(item.Id, item);
        }
    }
}