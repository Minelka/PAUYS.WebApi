using PAUYS.DTO.Abstract;
using System.Linq.Expressions;

namespace PAUYS.DAL.Services.Abstract
{
    public interface IDalService<TDto> where TDto : BaseDto
    {
        void Add(TDto dto);
        void Update(TDto dto);
        void Delete(TDto dto);
        void Delete(int id);

        TDto? Get(int id);
        ICollection<TDto> GetAll();
        //ICollection<TDto> GetAll<TProperty>(Expression<Func<TDto, bool>> predicate = null, params Expression<Func<TDto, object>>[] includes);
        ICollection<TDto> GetAll(Expression<Func<TDto, bool>> predicate = null, params string[] includeStringPath);

        int Save();
    }
}
