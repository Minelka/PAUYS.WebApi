using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.BLL.Managers.Concrete;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productmanager;

        public ProductController(IProductManager productmanager)
        {
            _productmanager = productmanager;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            var x = _productmanager.GetAll();

            return x;
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public ProductViewModel? Get(int id)
        {
            return _productmanager.GetById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //model.ConvertPicture();
            _productmanager.Add(model);
            _productmanager.Save();

            return Created("", model);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //model.ConvertPicture();
            _productmanager.Update(model);
            _productmanager.Save();

            return NoContent();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ProductViewModel? model = _productmanager.GetById(id);

            _productmanager.Delete(model);
            _productmanager.Save();

            return NoContent();
        }

        //[HttpPut("UploadProductPicture")]
        //[Consumes("multipart/form-data")]
        //public async Task<IActionResult> UploadProductPicture([FromForm] ProductViewModel model)
        //{
        //    if (model.PictureFormFile == null || model.PictureFormFile.Length == 0)
        //    {
        //        return BadRequest("Geçersiz ürün fotoğrafı.");
        //    }

        //    // Ürünü kontrol et
        //    var product = _productmanager.GetById(model.Id);
        //    if (product == null)
        //    {
        //        return NotFound("Ürün bulunamadı.");
        //    }

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        // Fotoğrafı belleğe yükle
        //        await model.PictureFormFile.CopyToAsync(memoryStream);
        //        product.Picture = memoryStream.ToArray();
        //        product.PictureFileName = model.PictureFormFile.FileName;
        //    }

        //    // Ürünü güncelle
        //    try
        //    {
        //        _productmanager.Update(product);
        //        _productmanager.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Ürün fotoğrafı güncellenirken bir hata oluştu: {ex.Message}");
        //    }

        //    return Ok("Ürün fotoğrafı başarıyla güncellendi.");
        //}
        //-------------------------------------------------------------
        //[HttpPut("UploadProfilePicture")]
        //public async Task<IActionResult> UploadProfilePicture(IFormFile profilePicture)
        //{
        //    if (profilePicture == null || profilePicture.Length == 0)
        //    {
        //        return BadRequest("Geçersiz profil fotoğrafı.");
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound("Kullanıcı bulunamadı.");
        //    }

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        await profilePicture.CopyToAsync(memoryStream);
        //        user.ProfilePicture = memoryStream.ToArray();
        //    }

        //    var result = await _userManager.UpdateAsync(user);
        //    if (!result.Succeeded)
        //    {
        //        return BadRequest("Profil fotoğrafı güncellenirken bir hata oluştu.");
        //    }

        //    return Ok("Profil fotoğrafı başarıyla güncellendi.");
        //}


        //[HttpGet("Picture/{id}")]
        //public async Task<ActionResult> GetUserPicture(string id)
        //{
        //    var product = await _productmanager.FindByIdAsync(id);  // burası düzenle

        //    if (product == null)
        //    {
        //        return NotFound("Kullanıcı bulunamadı.");
        //    }

        //    string base64String = "";
        //    if (product.ProfilePicture is null)
        //    {
        //        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "default-profile-picture.jpg");
        //        if (!System.IO.File.Exists(imagePath))
        //        {
        //            throw new Exception("Varsayılan resim bulunamadı");
        //        }


        //        base64String = Convert.ToBase64String(System.IO.File.ReadAllBytes(imagePath));
        //    }
        //    else
        //    {
        //        base64String = Convert.ToBase64String(product.ProfilePicture);
        //    }


        //    return Ok(base64String);
        //}

        //-------------------------------------------------------------




        //[HttpGet("Picture/{id}")]
        //public ActionResult GetProductPicture(int id)
        //{
        //    // Ürünü kontrol et
        //    var product = _productmanager.GetById(id);
        //    if (product == null)
        //    {
        //        return NotFound("Ürün bulunamadı.");
        //    }

        //    string base64String;

        //    // Ürün resmi yoksa varsayılan bir resim kullan
        //    if (product.Picture is null || product.Picture.Length == 0)
        //    {
        //        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "default-product-picture.jpg");
        //        if (!System.IO.File.Exists(imagePath))
        //        {
        //            return StatusCode(500, "Varsayılan ürün resmi bulunamadı.");
        //        }

        //        // Varsayılan resim dosyasını Base64'e dönüştür
        //        base64String = Convert.ToBase64String(System.IO.File.ReadAllBytes(imagePath));
        //    }
        //    else
        //    {
        //        // Ürün resmi varsa Base64'e dönüştür
        //        base64String = Convert.ToBase64String(product.Picture);
        //    }

        //    return Ok(base64String);
        //}

    }
}
