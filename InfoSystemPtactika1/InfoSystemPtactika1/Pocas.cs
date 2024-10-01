using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class Pocas
    {
        public static void ProcessDataFromString()
        {
            const string inputProduct = "Поступление товара:  2023.04.15  \"Футболка\"  10";
            const string inputSupplier = "Поставщик:  \"Поставщик Геральт\"  2024.10.02  \"Тапки\"  10";
            const string inputPurchase = "Информация о покупке:  2021.04.27  \"Шмотки\"  10  500";

            string[] stroki = { inputProduct, inputSupplier, inputPurchase };
            foreach (string stroka in stroki)
            {
                if (stroka.Contains("Поступление товара:"))
                {
                    Functions.ProcessProduct(stroka);
                }
                else if (stroka.Contains("Поставщик:"))
                {
                    Functions.ProcessSupplier(stroka);
                }
                else if (stroka.Contains("Информация о покупке:"))
                {
                    Functions.ProcessPurchase(stroka);
                }
            }
        }
    }
}
