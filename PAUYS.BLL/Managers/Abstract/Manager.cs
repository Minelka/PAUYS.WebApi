using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Abstract;
using PAUYS.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Abstract
{
    public abstract class Manager<TViewModel, TDto, TKey>(IDalService<TDto> service, IMapper mapper) : IManager<TViewModel, TDto>
        where TViewModel : BaseViewModel<TKey>
        where TDto : BaseDto
    {
        private protected readonly IMapper _mapper = mapper;
        private protected readonly IDalService<TDto> _service = service;
        private protected readonly MapperConfiguration _config = null!;

        public void Add(TViewModel model)
        {
            TDto dto = _mapper.Map<TDto>(model);

            _service.Add(dto);
        }

        public void Delete(TViewModel model)
        {
            TDto dto = _mapper.Map<TDto>(model);

            _service.Delete(dto);
        }

        public void Update(TViewModel model)
        {
            TDto dto = _mapper.Map<TDto>(model);

            _service.Update(dto);
        }

        public ICollection<TViewModel> GetAll()
        {
            ICollection<TDto> dtos = _service.GetAll();
            ICollection<TViewModel> viewModels = _mapper.Map<ICollection<TViewModel>>(dtos);

            return viewModels;
        }

        //public ICollection<TViewModel> GetAll(Expression<Func<TViewModel,bool>> predicate = null, params Expression<Func<TViewModel, object>>[] includes)
        //{
        //    Expression<Func<TDto, bool>> _predicate = _mapper.Map<Expression<Func<TDto, bool>>>(predicate);
        //    Expression<Func<TDto, object>>[] _includes = new Expression<Func<TDto, object>>[includes.Length];
        //    int i = 0;
        //    foreach (Expression<Func<TViewModel, object>> include in includes)
        //    {
        //        _includes[i] = _mapper.MapExpression<Expression<Func<TDto, object>>>(include); ;
        //        i++;
        //    }
        //    ICollection<TDto> dtos = _service.GetAll(_predicate, _includes);
        //    ICollection<TViewModel> viewModels = _mapper.Map<ICollection<TViewModel>>(dtos);
        //    return viewModels;
        //}

        public ICollection<TViewModel> GetAll(Expression<Func<TViewModel, bool>> predicate = null, params string[] includeStringPath)
        {
            Expression<Func<TDto, bool>> _predicate = _mapper.Map<Expression<Func<TDto, bool>>>(predicate);

            ICollection<TDto> dtos = _service.GetAll(_predicate, includeStringPath);

            ICollection<TViewModel> viewModels = _mapper.Map<ICollection<TViewModel>>(dtos);

            return viewModels;
        }

        public TViewModel? GetById(int id)
        {
            TDto? dto = _service.Get(id);
            TViewModel? viewModel = _mapper.Map<TViewModel>(dto);

            return viewModel;
        }

        public int Save()
        {
            return _service.Save();
        }
    }
}