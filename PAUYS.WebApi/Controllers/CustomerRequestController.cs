using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.BLL.Managers.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRequestController : ControllerBase
    {
        private readonly ICustomerRequestManager _customerRequestmanager;

        public CustomerRequestController(ICustomerRequestManager customerRequestmanager)
        {
            _customerRequestmanager = customerRequestmanager;
        }

        [HttpGet]
        public IEnumerable<CustomerRequestViewModel> Get()
        {
            var x = _customerRequestmanager.GetAll();

            return x;
        }

        [HttpGet("{id}")]
        public CustomerRequestViewModel? Get(int id)
        {
            return _customerRequestmanager.GetById(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerRequestViewModel model)
        {
            _customerRequestmanager.Add(model);
            _customerRequestmanager.Save();

            return Created("", model);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerRequestViewModel model)
        {
            _customerRequestmanager.Update(model);
            _customerRequestmanager.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            CustomerRequestViewModel? model = _customerRequestmanager.GetById(id);

            _customerRequestmanager.Delete(model);
            _customerRequestmanager.Save();

            return NoContent();
        }
    }
}
