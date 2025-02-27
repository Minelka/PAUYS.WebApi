using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.UnıtOfWorks;
using PAUYS.DTO.Abstract;
using PAUYS.Entity.Entities.Abstract;
using System.Linq.Expressions;

namespace PAUYS.DAL.Services.Abstract
{
    public abstract class DalService<TDto, TEntity> : IDalService<TDto>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        private protected readonly IUnitOfWork _unitOfWork;
        private protected IRepository<TEntity> _repository;
        private protected IMapper _mapper;

        //test comment
        protected DalService(IUnitOfWork unitOfWork, IRepository<TEntity> repository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            _repository.Add(entity);
        }

        public void Update(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            _repository.Update(entity);
        }

        public void Delete(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            _repository.Delete(entity);
        }

        public void Delete(int id)
        {
            TEntity? entity = _repository.Get(id);
            if(entity is not null)
                _repository.Delete(entity);
        }

        public TDto? Get(int id)
        {
            TEntity? entity = _repository.Get(id);
            TDto? dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public ICollection<TDto> GetAll()
        {
            ICollection<TEntity> entities = _repository.GetAll();
            ICollection<TDto> dtos = _mapper.Map<ICollection<TDto>>(entities);

            return dtos;
        }

        //public ICollection<TDto> GetAll<TProperty>(Expression<Func<TDto, bool>> predicate = null, params Expression<Func<TDto, object>>[] includes)
        //{
        //    Expression<Func<TEntity, bool>> _predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
        //    Expression<Func<TEntity, object>>[] _includes = new Expression<Func<TEntity, object>>[includes.Length];
        //    int i = 0;
        //    foreach (Expression<Func<TDto, object>> include in includes)
        //    {
        //        _includes[i] = _mapper.Map<Expression<Func<TEntity, object>>>(include); ;
        //        i++;
        //    }
        //    ICollection<TEntity> entities = _repository.GetAll(_predicate, _includes);
        //    ICollection<TDto> dtos = _mapper.Map<ICollection<TDto>>(entities);
        //    return dtos;
        //}

        public ICollection<TDto> GetAll(Expression<Func<TDto, bool>> predicate = null, params string[] includeStringPath)
        {

            Expression<Func<TEntity, bool>> _predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            ICollection<TEntity> entities = _repository.GetAll(_predicate, includeStringPath);

            ICollection<TDto> dtos = _mapper.Map<ICollection<TDto>>(entities);

            return dtos;
        }

        public int Save()
        {
            return _unitOfWork.Complete();
        }
    }
}
