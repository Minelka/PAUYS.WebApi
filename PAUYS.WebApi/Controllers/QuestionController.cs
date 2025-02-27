using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionManager _questionmanager;

        public QuestionController(IQuestionManager questionmanager)
        {
            _questionmanager = questionmanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<QuestionViewModel> Get()
        {
            var x = _questionmanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public QuestionViewModel? Get(int id)
        {
            return _questionmanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] QuestionViewModel model)
        {
            _questionmanager.Add(model);
            _questionmanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] QuestionViewModel model)
        {
            _questionmanager.Update(model);
            _questionmanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            QuestionViewModel? model = _questionmanager.GetById(id);

            _questionmanager.Delete(model);
            _questionmanager.Save();

            return NoContent();
        }
    }
}
