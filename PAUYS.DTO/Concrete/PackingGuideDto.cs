using PAUYS.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DTO.Concrete
{
    public class PackingGuideDto : BaseDto
    {
        public string Confirmation { get; set; }
        public string Sample { get; set; }
        public string MoldProduction { get; set; }
        public string Finalization { get; set; }
    }
}

    