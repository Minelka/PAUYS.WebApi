using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
    public class Question : BaseEntity
    {
        public string Questions { get; set; }
        public string Answer { get; set; }
    }
}
