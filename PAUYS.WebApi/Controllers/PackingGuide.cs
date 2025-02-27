using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackingGuideController : ControllerBase
    {
        private readonly IPackingGuideManager _packingGuidemanager;

        public PackingGuideController(IPackingGuideManager packingGuidemanager)
        {
            _packingGuidemanager = packingGuidemanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<PackingGuideViewModel> Get()
        {
            var x = _packingGuidemanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public PackingGuideViewModel? Get(int id)
        {
            return _packingGuidemanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] PackingGuideViewModel model)
        {
            _packingGuidemanager.Add(model);
            _packingGuidemanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PackingGuideViewModel model)
        {
            _packingGuidemanager.Update(model);
            _packingGuidemanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            PackingGuideViewModel? model = _packingGuidemanager.GetById(id);

            _packingGuidemanager.Delete(model);
            _packingGuidemanager.Save();

            return NoContent();
        }
    }
}
