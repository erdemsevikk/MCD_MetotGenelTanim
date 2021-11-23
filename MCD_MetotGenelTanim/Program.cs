using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Selamla();

            Ogrenci o1 = new Ogrenci();
            o1.ogrenciMetot2();
            o1.selamlaOgrenci();


            Console.ReadLine();
        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        
    }
}
