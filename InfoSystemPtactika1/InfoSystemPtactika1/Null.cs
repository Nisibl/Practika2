using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    public class Null
    {
        public static int LongestZeroSequenceInStr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("Пустая строка");
            }

            int maxCount = 0;
            int currentCount = 0; 

            foreach (char b in str)
            {
                if (b == '0')
                {
                    currentCount++; 
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount; 
                    }
                }
                else
                {
                    currentCount = 0; 
                }
            }
            return maxCount; 
        }
    }
}
