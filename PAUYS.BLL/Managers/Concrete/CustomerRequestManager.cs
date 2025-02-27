using AutoMapper;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Concrete
{
    public class CustomerRequestManager : Manager<CustomerRequestViewModel, CustomerRequestDto, int>, ICustomerRequestManager
    {
        public CustomerRequestManager(ICustomerRequestDalService service, IMapper mapper) : base(service, mapper) { }

    }
}
