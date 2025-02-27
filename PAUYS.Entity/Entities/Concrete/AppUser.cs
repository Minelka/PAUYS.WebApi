using Microsoft.AspNetCore.Identity;

namespace PAUYS.Entity.Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        // Opsiyonel olarak, kullanıcının profil fotoğrafı URL'sini tutabilirsiniz
        public string? PictureFileName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

// Add profile data for application users by adding properties to the AppUser class


