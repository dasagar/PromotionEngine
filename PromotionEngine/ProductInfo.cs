using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
   public  class ProductInfo
    {
            public string ProductId { get; set; }
            public decimal ProductPrice { get; set; }

            public decimal DiscountedPriceOn3A { get; set; } = 130m;
            public decimal DiscountedPriceOn2B { get; set; } = 45m;
            public decimal DiscountedPriceOnCD { get; set; } = 5;
            public ProductInfo(string productId)
            {
                this.ProductId = productId;
                switch (this.ProductId)
                {
                    case "A":
                        this.ProductPrice = 50m;
                        break;
                    case "B":
                        this.ProductPrice = 30m;

                        break;
                    case "C":
                        this.ProductPrice = 20m;

                        break;
                    case "D":
                        this.ProductPrice = 15m;
                        break;
                default:
                    Console.WriteLine("Please enter the correct Id of Product");
                    break;
                }
            }
        }
}
