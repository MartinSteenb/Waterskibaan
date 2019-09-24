using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Waterskibaan
    {
        Kabel kabel;
        LijnenVoorraad voorraad = new LijnenVoorraad();

        public Waterskibaan(Kabel kabel)
        {
            this.kabel = kabel;
            for(int i = 0; i < 15; i++)
            {
                voorraad.LijnToevoegenAanRij(new Lijn());
            }
        }
        public void VerplaatsKabel()
        {
            kabel.VerschuifLijnen();
            voorraad.LijnToevoegenAanRij(kabel.VerwijderLijnVanKabel());
        }

        public override string ToString()
        {
            return voorraad.ToString() + "\n" + kabel.ToString();
        }
    }
}
