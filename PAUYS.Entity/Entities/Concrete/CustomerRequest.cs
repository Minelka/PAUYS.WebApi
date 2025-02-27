using PAUYS.Entity.Entities.Abstract;

namespace PAUYS.Entity.Entities.Concrete
{
    public class CustomerRequest : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; }

        public string CustomerMessage { get; set; }

        public string? AdminMessage { get; set; }

        public bool RefundorNewRequest { get; set; } 
    }
}
