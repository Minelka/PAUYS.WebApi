using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;


namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialManager _materialmanager;

        public MaterialController(IMaterialManager materialmanager)
        {
            _materialmanager = materialmanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<MaterialViewModel> Get()
        {
            var x = _materialmanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public MaterialViewModel? Get(int id)
        {
            return _materialmanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] MaterialViewModel model)
        {
            _materialmanager.Add(model);
            _materialmanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MaterialViewModel model)
        {
            _materialmanager.Update(model);
            _materialmanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            MaterialViewModel? model = _materialmanager.GetById(id);

            _materialmanager.Delete(model);
            _materialmanager.Save();

            return NoContent();
        }
    }
}