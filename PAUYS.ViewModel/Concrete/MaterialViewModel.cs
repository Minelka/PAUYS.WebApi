using PAUYS.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.ViewModel.Concrete
{
    public class MaterialViewModel : BaseViewModel<int>
    {
        public MaterialViewModel() : base(0) { }

        [Display(Name = "Materyal Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; } = null!;

        //entityde Product listesi var
        public ICollection<ProductViewModel>? ProductViewModels { get; set; }  //Book store de entitydeki de Icollection
        //


    }
}
