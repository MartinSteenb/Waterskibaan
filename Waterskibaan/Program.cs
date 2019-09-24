using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TestOpdracht2();
            //TestOpdracht3();
            TestOpdracht4();
        }
        private static void TestOpdracht2()
        {
            Kabel kabel = new Kabel();
            for(int i = 0; i <= 9; i++)
            {
                kabel.NeemLijnInGebruik(new Lijn());
            }
           
            Console.WriteLine(kabel);
            kabel.VerschuifLijnen();
            Console.WriteLine(kabel);
        }

        private static void TestOpdracht3()
        {
            LijnenVoorraad voorraad = new LijnenVoorraad();

            voorraad.LijnToevoegenAanRij(new Lijn());
            voorraad.LijnToevoegenAanRij(new Lijn());
            voorraad.LijnToevoegenAanRij(new Lijn());
            Console.WriteLine(voorraad);

            voorraad.VerwijderEersteLijn();
            Console.WriteLine(voorraad);
        }

        private static void TestOpdracht4()
        {
            Kabel kabel = new Kabel();
            for (int i = 0; i <= 9; i++)
            {
                kabel.NeemLijnInGebruik(new Lijn());
            }
            Waterskibaan waterskibaan = new Waterskibaan(kabel);
            Console.WriteLine(waterskibaan);
        }
    }
}
