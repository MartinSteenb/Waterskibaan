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
            Lijn lijn1 = new Lijn();
            lijn1.PositieOpDeKabel = 1;

            Lijn lijn2 = new Lijn();
            lijn2.PositieOpDeKabel = 0;

            Lijn lijn3 = new Lijn();
            lijn3.PositieOpDeKabel = 2;

            Kabel kabel = new Kabel();
            kabel.NeemLijnInGebruik(lijn1);
            kabel.NeemLijnInGebruik(lijn2);
            kabel.NeemLijnInGebruik(lijn3);


            foreach (Lijn ch in kabel.getList())
                Console.Write(ch.PositieOpDeKabel + " ");

        }
        
    }
}
