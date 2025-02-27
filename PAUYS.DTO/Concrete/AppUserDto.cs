using PAUYS.DTO.Abstract;

namespace PAUYS.DTO.Concrete
{
    public class AppUserDto : BaseDto
    {
        public string Name { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string Password { get; set; }    
        public string Email { get; set; }

        // Opsiyonel olarak, kullanıcının profil fotoğrafı URL'sini tutabilirsiniz
        public string? PictureFileName { get; set; } = string.Empty;
    }
}
