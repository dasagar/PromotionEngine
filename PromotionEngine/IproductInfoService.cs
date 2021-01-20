using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
   interface IproductInfoService
    {
            
             int GetTotalPrice(List<ProductInfo> products);
    }


}
