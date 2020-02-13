using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Upisite tri dvoznamenkasta broja odvojena zarezom: ");
            string unos = Console.ReadLine();




            int prviBroj = Convert.ToInt32(unos.Substring(0,2));
            int drugiBroj = Convert.ToInt32(unos.Substring(3, 2));
            int treciBroj = Convert.ToInt32(unos.Substring(6, 2));

            if(prviBroj>drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine("Najveci broj je: " + prviBroj);
            }
            else if(drugiBroj>prviBroj && drugiBroj > treciBroj)
            {
                Console.WriteLine("Najveci broj je: " + drugiBroj);
            }
            else
            {
                Console.WriteLine("Najveci broj je: " + treciBroj);
            }
                

            Console.ReadKey();
             
        }
    }
}
