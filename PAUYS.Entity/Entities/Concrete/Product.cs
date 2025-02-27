using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; } = 0m;
        public byte[]? Picture { get; set; }
        public string? PictureFileName { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; } = null!; // Hangi Material olduğunu belirliyoruz

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!; // Hangi Category olduğunu belirliyoruz
       
    }
}
