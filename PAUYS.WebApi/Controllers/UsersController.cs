using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExampleProduct.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<UserResponseViewModel> Get()
        {
            return _userManager.Users
                                .Select(u => new UserResponseViewModel 
                                {
                                    Id = u.Id, 
                                    FirstName = u.FirstName, 
                                    LastName = u.LastName,
                                    UserName = u.UserName,
                                    Email = u.Email,
                                    PictureFileName = u.PictureFileName
                                });


        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public UserResponseViewModel? Get(string id)
        {
            return _userManager.Users
                                .Where(u => u.Id == id)
                                .Select(u => new UserResponseViewModel
                                {
                                    Id = u.Id,
                                    FirstName = u.FirstName,
                                    LastName = u.LastName,
                                    UserName = u.UserName,
                                    Email = u.Email,
                                    PictureFileName = u.PictureFileName
                                })
                                .SingleOrDefault();
        }

        // GET api/<UsersController>/5/Roles
        [HttpGet("{id}/Roles")]
        public UserWithRolesResponseViewModel? GetWithRoles(string id)
        {
            AppUser? user = _userManager.Users
                                .Where(u => u.Id == id)
                                .SingleOrDefault();

            List<string> userRoles = _userManager.GetRolesAsync(user).Result.ToList();

            List<RoleResponseViewModel> roles = _roleManager.Roles.Where(r => userRoles.Contains(r.Name)).ToList().Select(r2 => new RoleResponseViewModel { Id = r2.Id, Name = r2.Name }).ToList();

            var model = new UserWithRolesResponseViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                PictureFileName = user.PictureFileName,
                Roles = roles
            };

            return model;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] UserCreateRequestViewModel model)
        {
            AppUser user = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email,
                PictureFileName = model.PictureFileName
            };

            IdentityResult result = _userManager.CreateAsync(user, model.Password).Result;

            string location = $"/api/Users/Get/{user.Id}";

            if (result.Succeeded)
                return Created(location, new UserResponseViewModel 
                                            { 
                                                Id = user.Id, 
                                                FirstName = user.FirstName, 
                                                LastName = user.LastName, 
                                                Email = user.Email, 
                                                UserName = user.UserName,
                                                PictureFileName = user.PictureFileName
                });
            else
                return BadRequest(result.Errors);
        }

        // POST api/<UsersController>/5/Roles/3
        [HttpPost("{id}/Roles/{roleId}")]
        public ActionResult PostUserRole(string id, string roleId)
        {
            AppUser? user = _userManager.Users
                                        .Where(u => u.Id == id)
                                        .SingleOrDefault();

            IdentityRole? role = _roleManager.Roles
                                             .Where(r => r.Id == roleId)
                                             .SingleOrDefault();

            IdentityResult result = _userManager.AddToRoleAsync(user, role.Name).Result;

            List<string> userRoles = _userManager.GetRolesAsync(user).Result.ToList();

            List<RoleResponseViewModel> roles = _roleManager.Roles.Where(r => userRoles.Contains(r.Name)).ToList().Select(r2 => new RoleResponseViewModel { Id = r2.Id, Name = r2.Name }).ToList();

            if (result.Succeeded)
                return Created("", new UserWithRolesResponseViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    UserName = user.UserName,
                    PictureFileName = user.PictureFileName,
                    Roles = roles
                });
            else
                return BadRequest(result.Errors);

        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] UserUpdateRequestViewModel model)
        {
            AppUser? user = _userManager.Users
                                .Where(u => u.Id == id)
                                .SingleOrDefault();

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.UserName = model.Email;

            IdentityResult result = _userManager.UpdateAsync(user).Result;

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            AppUser? user = _userManager.Users
                                .Where(u => u.Id == id)
                                .SingleOrDefault();


            IdentityResult result = _userManager.DeleteAsync(user).Result;

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors);
        }

        // POST api/<UsersController>/5/Roles/3
        [HttpDelete("{id}/Roles/{roleId}")]
        public ActionResult DeleteUserRole(string id, string roleId)
        {
            AppUser? user = _userManager.Users
                                        .Where(u => u.Id == id)
                                        .SingleOrDefault();

            IdentityRole? role = _roleManager.Roles
                                             .Where(r => r.Id == roleId)
                                             .SingleOrDefault();

            IdentityResult result = _userManager.RemoveFromRoleAsync(user, role.Name).Result;

            List<string> userRoles = _userManager.GetRolesAsync(user).Result.ToList();

            List<RoleResponseViewModel> roles = _roleManager.Roles.Where(r => userRoles.Contains(r.Name)).ToList().Select(r2 => new RoleResponseViewModel { Id = r2.Id, Name = r2.Name }).ToList();

            if (result.Succeeded)
                return Created("", new UserWithRolesResponseViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    UserName = user.UserName,
                    PictureFileName = user.PictureFileName,
                    Roles = roles
                });
            else
                return BadRequest(result.Errors);

        }
    }
}
