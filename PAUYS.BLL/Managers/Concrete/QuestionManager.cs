using AutoMapper;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.BLL.Managers.Concrete
{
    public class QuestionManager : Manager<QuestionViewModel, QuestionDto, int>, IQuestionManager
    {
        public QuestionManager(IQuestionDalService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
