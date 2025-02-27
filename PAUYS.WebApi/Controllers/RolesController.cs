using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        public RolesController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }

        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<RoleResponseViewModel> Get()
        {
            return _roleManager.Roles
                                .Select(r => new RoleResponseViewModel
                                {
                                    Id = r.Id,
                                    Name = r.Name
                                });


        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public RoleResponseViewModel? Get(string id)
        {
            return _roleManager.Roles
                        .Where(r => r.Id == id)
                        .Select(r => new RoleResponseViewModel
                        {
                            Id = r.Id,
                            Name = r.Name
                        })
                        .SingleOrDefault();
        }

        // GET api/<RolesController>/5/Users
        [HttpGet("{id}/Users")]
        public IEnumerable<UserResponseViewModel>? GetIdWithUsers(string id)
        {
            RoleResponseViewModel? role = _roleManager.Roles
                                        .Where(r => r.Id == id)
                                        .Select(r => new RoleResponseViewModel
                                        {
                                            Id = r.Id,
                                            Name = r.Name
                                        })
                                        .SingleOrDefault();

            return _userManager.GetUsersInRoleAsync(role.Name)
                                .Result
                                .Select(u => new UserResponseViewModel
                                {
                                    Id = u.Id,
                                    FirstName = u.FirstName,
                                    LastName = u.LastName,
                                    UserName = u.UserName,
                                    Email = u.Email,
                                    PictureFileName = u.PictureFileName
                                })
                                .ToList();
        }

        // GET api/<RolesController>/Name/Admin/Users
        [HttpGet("Name/{name}/Users")]
        public IEnumerable<UserResponseViewModel>? GetNameWithUsers(string name)
        {
            
            return _userManager.GetUsersInRoleAsync(name)
                                .Result
                                .Select(u => new UserResponseViewModel
                                {
                                    Id = u.Id,
                                    FirstName = u.FirstName,
                                    LastName = u.LastName,

                                    UserName = u.UserName,
                                    Email = u.Email,
                                    PictureFileName = u.PictureFileName
                                })
                                .ToList();
        }

        // POST api/<RolesController>
        [HttpPost]
        public ActionResult Post([FromBody] RoleCreateRequestViewModel model)
        {
            IdentityRole role = new IdentityRole
            {
                Name = model.Name
            };

            IdentityResult result = _roleManager.CreateAsync(role).Result;

            string location = $"/api/Roles/Get/{role.Id}";

            if (result.Succeeded)
                return Created(location, new RoleResponseViewModel
                {
                    Id = role.Id,
                    Name = role.Name,
                });
            else
                return BadRequest(result.Errors);
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] RoleUpdateRequestViewModel model)
        {
            IdentityRole? role = _roleManager.Roles
                                .Where(r => r.Id == id)
                                .SingleOrDefault();

            role.Name = model.Name;

            IdentityResult result = _roleManager.UpdateAsync(role).Result;

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors);
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            IdentityRole? role = _roleManager.Roles
                                .Where(r => r.Id == id)
                                .SingleOrDefault();


            IdentityResult result = _roleManager.DeleteAsync(role).Result;

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors);
        }
    }
}
