using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
    public class Category: BaseEntity
    {
        public string Name { get; set; } = null!; // Kategori adı

        public string? Shape { get; set; }
        public string Description { get; set; } = null!; // Kategori açıklaması

        public string UsingArea { get; set; } = null!; //Kullanım Alanı

        public ICollection<Product> Products { get; set; }  // Katalogdaki ürünler
    }
}
