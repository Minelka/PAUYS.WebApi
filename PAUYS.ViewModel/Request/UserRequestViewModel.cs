namespace PAUYS.ViewModel.Concrete
{
    public class UserCreateRequestViewModel : UserUpdateRequestViewModel
    {
        public string Password { get; set; } = null!;
    }

    public class UserUpdateRequestViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public string? PictureFileName { get; set; } = string.Empty;
    }
}
