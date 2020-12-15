using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenStore.Model;
namespace OpenStore
{
    public class SampleData
    {
        public static void Initialize(ProductContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "iPhone X",
                        Brand = "Apple",
                        Price = 600,
                        ImageSrc = "",
                        Quantity = 999,
                        ShortDescribe = "its IPhone",
                        Describe = "It is Iphone",
                        Characteristics = "nfc,camera-1pcs"
                    },
                    new Product
                    {
                        Name = "iPhone Xr",
                        Brand = "Apple",
                        Price = 600,
                        ImageSrc = "",
                        Quantity = 999,
                        ShortDescribe = "its IPhone",
                        Describe = "It is Iphone",
                        Characteristics = "nfc,camera-1pcs"
                    },
                    new Product
                    {
                        Name = "iPhone 12 mini",
                        Brand = "Apple",
                        Price = 600,
                        ImageSrc = "",
                        Quantity = 999,
                        ShortDescribe = "its IPhone",
                        Describe = "It is Iphone",
                        Characteristics = "nfc,camera-1pcs"
                    },
                    new Product
                    {
                        Name = "iPhone 12 ",
                        Brand = "Apple",
                        Price = 600,
                        ImageSrc = "",
                        Quantity = 999,
                        ShortDescribe = "its IPhone",
                        Describe = "It is Iphone",
                        Characteristics = "nfc,camera-1pcs"
                    },
                     new Product
                     {
                         Name = "iPhone 12 pro",
                         Brand = "Apple",
                         Price = 600,
                         ImageSrc = "",
                         Quantity = 999,
                         ShortDescribe = "its IPhone",
                         Describe = "It is Iphone",
                         Characteristics = "nfc,camera-1pcs"
                     },
                      new Product
                      {
                          Name = "iPhone 12 max",
                          Brand = "Apple",
                          Price = 600,
                          ImageSrc = "",
                          Quantity = 999,
                          ShortDescribe = "its IPhone",
                          Describe = "It is Iphone",
                          Characteristics = "nfc,camera-1pcs"
                      },
                     new Product
                     {
                         Name = "iPhone 12 pro max",
                         Brand = "Apple",
                         Price = 600,
                         ImageSrc = "",
                         Quantity = 999,
                         ShortDescribe = "its IPhone",
                         Describe = "It is Iphone",
                         Characteristics = "nfc,camera-1pcs"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}
