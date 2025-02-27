using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController : ControllerBase
	{
		private readonly IBlogManager _blogmanager;

		public BlogController(IBlogManager blogManager)
		{
			_blogmanager = blogManager;
		}

		// GET: api/<AuthorsController>
		[HttpGet]
		public IEnumerable<BlogViewModel> Get()
		{
			var x = _blogmanager.GetAll();

			return x;
		}

		// GET api/<AuthorsController>/5
		[HttpGet("{id}")]
		public BlogViewModel? Get(int id)
		{
			return _blogmanager.GetById(id);
		}

		// POST api/<AuthorsController>
		[HttpPost]
		public ActionResult Post([FromBody] BlogViewModel model)
		{
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _blogmanager.Add(model);
			_blogmanager.Save();

			return Created("", model);
		}

		// PUT api/<AuthorsController>/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromBody] BlogViewModel model)
		{
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _blogmanager.Update(model);
			_blogmanager.Save();

			return NoContent();
		}

		// DELETE api/<AuthorsController>/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			BlogViewModel? model = _blogmanager.GetById(id);

			_blogmanager.Delete(model);
			_blogmanager.Save();

			return NoContent();
		}
	}
}
