using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductInfo> products = new List<ProductInfo>();
            ProductInfoService prodService = new ProductInfoService();
            Console.WriteLine("Input:Enter the number of products");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Id of Product :A,B,C or D");
                string id = Console.ReadLine();
                ProductInfo p = new ProductInfo(id.ToUpper());
                products.Add(p);
            }

            int totalPrice = prodService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
