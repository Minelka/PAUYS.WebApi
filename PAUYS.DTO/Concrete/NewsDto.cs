using PAUYS.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DTO.Concrete
{
	public class NewsDto : BaseDto
	{
		public string Title { get; set; }
		public string Text { get; set; }
		public byte[]? Picture { get; set; }
		public string? PictureFileName { get; set; }
	}
}
