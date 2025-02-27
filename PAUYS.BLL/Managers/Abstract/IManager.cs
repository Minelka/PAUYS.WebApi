using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Abstract
{
    public interface IManager<TViewModel, TDto>
        where TViewModel : class
        where TDto : BaseDto
    {
        void Add(TViewModel model);
        void Update(TViewModel model);
        void Delete(TViewModel model);
        TViewModel? GetById(int id);
        ICollection<TViewModel> GetAll();
        //ICollection<TViewModel> GetAll<TProperty>(Expression<Func<TViewModel, bool>> predicate = null, params Expression<Func<TViewModel, object>>[] includes);
        ICollection<TViewModel> GetAll(Expression<Func<TViewModel, bool>> predicate = null, params string[] includeStringPath);
        int Save();
    }
}
