using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenStore.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageSrc { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ShortDescribe { get; set; }
        public string Describe { get; set; }
        public string Brand { get; set; }
        public string Characteristics { get; set; }

    }
}
