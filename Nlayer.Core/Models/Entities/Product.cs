using Nlayer.Core.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Models.Entities
{
    public class Product:BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public Category? Category { get; set; }
        public ProductFeature? ProductFeature { get; set; }
        public int CategoryId { get; set; }
    }
}
