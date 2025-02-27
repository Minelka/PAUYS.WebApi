using PAUYS.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.ViewModel.Concrete
{
    public class CategoryViewModel : BaseViewModel<int>
    {
        public CategoryViewModel() : base(0) { }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; } = null!;

        [Display(Name = "Şekli")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string? Shape { get; set; }
        
        [Display(Name = "Açıklaması")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Description { get; set; } = null!;
        
        [Display(Name = "Kullanım Alanı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string UsingArea { get; set; } = null!;

        // Product sınıfının Listesi var entityde
        public ICollection<ProductViewModel>? ProductViewModels { get; set; }  //Book store de entitydeki de Icollection
        //


    }
}
