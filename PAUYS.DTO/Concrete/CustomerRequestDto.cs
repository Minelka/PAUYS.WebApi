
using PAUYS.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DTO.Concrete
{
    public class CustomerRequestDto: BaseDto
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; }

        public string CustomerMessage { get; set; }

        public string? AdminMessage { get; set; }

        public bool RefundorNewRequest { get; set; } 
    }
}
