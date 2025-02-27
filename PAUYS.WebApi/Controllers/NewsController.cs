using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsManager _newsmanager;

        public NewsController(INewsManager newsmanager)
        {
            _newsmanager = newsmanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<NewsViewModel> Get()
        {
            var x = _newsmanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public NewsViewModel? Get(int id)
        {
            return _newsmanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] NewsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _newsmanager.Add(model);
            _newsmanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] NewsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _newsmanager.Update(model);
            _newsmanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            NewsViewModel? model = _newsmanager.GetById(id);

            _newsmanager.Delete(model);
            _newsmanager.Save();

            return NoContent();
        }
    }
}
