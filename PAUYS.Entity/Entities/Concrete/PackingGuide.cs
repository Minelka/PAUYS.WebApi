using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
    public class PackingGuide : BaseEntity
    {
        public string Confirmation { get; set; }
        public string Sample { get; set; }
        public string MoldProduction { get; set; }
        public string Finalization { get; set; }
    }
}
