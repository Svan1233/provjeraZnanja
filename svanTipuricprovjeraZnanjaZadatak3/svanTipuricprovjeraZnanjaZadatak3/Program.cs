using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricprovjeraZnanjaZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string unos=Console.ReadLine();
            
            
            
            string space = " ";
            for (int i = 0; i < unos.Length; i++)
            {
               Console.Write(space);

                for (int j = 0; j < unos.Length-1; j++)
                {
                    Console.WriteLine(unos.Substring(unos.Length-1-i));
                }
                

            }
            Console.ReadLine();


        }
        
    }
}
