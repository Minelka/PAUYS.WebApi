using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
	public class Blog : BaseEntity
	{
        public string Title { get; set; }
        public string Text { get; set; }
		public byte[]? Picture { get; set; }
		public string? PictureFileName { get; set; }
	}
}
