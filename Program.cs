using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadataka4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] n = { 35, 65.7, 77.5, 22.35, 1.1, 4, 5.555, 90, 40.12, 100, 0 };
            double closesToN = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < (n.Sum() / n.Length) && n[i] > closesToN)
                {
                    closesToN = n[i];
                }
            }
            Console.WriteLine(closesToN);
            Console.ReadLine();
        }
    }
}
