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
            Pocas.ProcessDataFromString();
            FileProcessor.ProcessDataFromFile("C:\\Users\\Елисей\\Documents\\GitHub\\Practika2\\InfoSystemPtactika1\\data.txt");
        }
    }
}
