using PAUYS.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DTO.Concrete
{
    public class QuestionDto: BaseDto
    {
        public string Questions { get; set; }
        public string Answer { get; set; }
    }
}
