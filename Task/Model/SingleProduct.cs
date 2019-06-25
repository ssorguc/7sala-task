using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Model
{
    public class SingleProduct
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
    }
}
