﻿namespace PAUYS.ViewModel.Concrete
{
    public class UserResponseViewModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public string? UserName { get; set; }

        public string? PictureFileName { get; set; } = string.Empty;
    }

    public class UserWithRolesResponseViewModel : UserResponseViewModel
    {
        public List<RoleResponseViewModel> Roles { get; set; } = null!;
    }
}
