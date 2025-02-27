using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categorymanager;

        public CategoryController(ICategoryManager categorymanager)
        {
            _categorymanager = categorymanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<CategoryViewModel> Get()
        {
            var x = _categorymanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public CategoryViewModel? Get(int id)
        {
            return _categorymanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] CategoryViewModel model)
        {
            _categorymanager.Add(model);
            _categorymanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CategoryViewModel model)
        {
            _categorymanager.Update(model);
            _categorymanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            CategoryViewModel? model = _categorymanager.GetById(id);

            _categorymanager.Delete(model);
            _categorymanager.Save();

            return NoContent();
        }
    }
}
