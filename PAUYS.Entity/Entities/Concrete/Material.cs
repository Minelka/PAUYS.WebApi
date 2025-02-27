using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Entity.Entities.Concrete
{
    public class Material : BaseEntity
    {
        public string Name { get; set; } = null!;

        //public string Description { get; set; }

        public ICollection<Product> Products { get; set; }  // Katalogdaki ürünler
    }
}
