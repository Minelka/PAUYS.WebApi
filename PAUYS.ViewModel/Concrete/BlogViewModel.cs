using Microsoft.AspNetCore.Http;
using PAUYS.Common.Validations;
using PAUYS.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.ViewModel.Concrete
{
	public class BlogViewModel : BaseViewModel<int>
	{
		public BlogViewModel() : base(0) { }

		[Display(Name = "Başlık Adı")]
		[Required(ErrorMessage = "Bu alan zorunludur.")]
		public string Title { get; set; } = null!;

		[Display(Name = "Yazı")]
		[Required(ErrorMessage = "Bu alan zorunludur.")]
		public string Text { get; set; } = null!;

        [Display(Name = "Fotoğrafı")]
        [ImageFile("image/png", "image/jpeg")]
        public IFormFile? PictureFormFile { get; set; } = null!;

        [Display(Name = "Fotoğrafı")]
        public byte[]? Picture { get; set; }

        [Display(Name = "Fotoğrafın Adı")]
        public string? PictureFileName { get; set; }
    }

    public class BlogAddViewModel : BlogViewModel
    {
        [Display(Name = "Fotoğrafı")]
        //[ImageFile("image/png", "image/jpeg")]
        public IFormFile? PictureFormFile { get; set; }

        public void ConvertPicture()
        {
            if (PictureFormFile != null && PictureFormFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    PictureFormFile.CopyTo(memoryStream);
                    Picture = memoryStream.ToArray();
                    PictureFileName = PictureFormFile.FileName;
                }
            }
        }
    }
}
