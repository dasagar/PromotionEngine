using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ProductInfoService : IproductInfoService
    {

        public int GetTotalPrice(List<ProductInfo> products)
        {
            int countA = 0, countB = 0, countC = 0, countD = 0;
            int aTotal=0, bTotal=0, combinedCDTotal=0;
            foreach (var pr in products)
            {
                switch (pr.ProductId)
                {
                    case "A":
                        countA += 1;
                        break;
                    case "B":
                        countB += 1;

                        break;
                    case "C":
                        countC += 1;

                        break;
                    case "D":
                        countD += 1;
                        break;

                }
            }
            if (products.Where(a => a.ProductId == "A").Count() > 0)
            {
                aTotal = (int)(countA / 3 * products.Where(a => a.ProductId == "A")?.FirstOrDefault().DiscountedPriceOn3A + (countA % 3 * products.Where(a => a.ProductId == "A")?.FirstOrDefault().ProductPrice));

            }
            if (products.Where(a => a.ProductId == "B").Count() > 0)
            {
                bTotal = (int)(countB / 2 * products.Where(a => a.ProductId == "B")?.FirstOrDefault()?.DiscountedPriceOn2B + (countB % 2 * products.Where(a => a.ProductId == "B")?.FirstOrDefault()?.ProductPrice));

            }
            decimal combinedPrice = 0m;
            if (products.Where(a => a.ProductId == "C").Count() > 0 && products.Where(a => a.ProductId == "D").Count() > 0)

            {
                combinedPrice = (decimal)(products.Where(a => a.ProductId == "C")?.FirstOrDefault().ProductPrice + products.Where(a => a.ProductId == "D")?.FirstOrDefault().ProductPrice - products.Where(a => a.ProductId == "C")?.FirstOrDefault().DiscountedPriceOnCD);
                if (countC.Equals(countD))
                {
                    combinedCDTotal = (int)(countD * combinedPrice);
                }
                    if (countC > countD)
                {
                    combinedCDTotal = (int)(countD * combinedPrice);
                    combinedCDTotal = (int)((countC - countD) * products.Where(a => a.ProductId == "C").FirstOrDefault().ProductPrice);
                }
                if (countD > countC)
                {
                    combinedCDTotal = (int)(countC * combinedPrice);
                    combinedCDTotal = (int)((countD - countC) * products.Where(a => a.ProductId == "D").FirstOrDefault().ProductPrice);
                }
            }
            else
            {
                if (products.Where(a => a.ProductId == "C").Count() > 0)
                {
                    combinedCDTotal = (int)((countC) * products.Where(a => a.ProductId == "C").FirstOrDefault().ProductPrice);
                }
                if (products.Where(a => a.ProductId == "D").Count() > 0)
                {
                    combinedCDTotal = (int)((countD) * products.Where(a => a.ProductId == "D").FirstOrDefault().ProductPrice);
                }
            }
           

            return aTotal + bTotal + combinedCDTotal;
        }
    }
}
