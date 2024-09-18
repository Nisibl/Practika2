using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfoSystemPtactika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string input = "Поступление товара:  2023.04.15  \"Футболка\"  10";

            ProductInfo product = ProductInfo.CreateProductFromString(input);
            
            product.PrintInfo();

        }
    }
}
