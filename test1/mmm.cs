using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class mmm
    {
        public static programs kkr = new programs();
        static void Main(string[] args)
        {
            string yon = "";

            do
            {
                Console.WriteLine("AYA MIKHAHID EDAME DAHID?--------------->>>>>(Y FOR YES.....&.......N FOR END)");
                 yon = Console.ReadLine();

                Console.WriteLine("Lotfan name Soal ra vared konid");
                string name = Console.ReadLine();
                kkr.allmethods(name);


                Console.WriteLine("hal kardi");
                Console.ReadLine();
                Console.Clear();    


            } while (yon == "y") ;
           

            

        }

        
    }
}
