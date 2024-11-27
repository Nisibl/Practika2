using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    public class Null
    {
        public static int CountNullInStr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("Пустая строка");
            }

            int c = 0;

            foreach (char b in str)
            {
                if (b == '0')
                {
                    c++;
                }
            }
            return c;
        }
    }
}
