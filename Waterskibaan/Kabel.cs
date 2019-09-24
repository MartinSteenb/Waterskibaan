using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Kabel
    {
        private LinkedList<Lijn> _lijnen = new LinkedList<Lijn>();

        public bool IsStartPositieLeeg()
        {
            if(_lijnen.First == null)
            {
                return true;
            }
            return false;
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            if(IsStartPositieLeeg())
            {
                lijn.PositieOpDeKabel = 0;
                _lijnen.AddFirst(lijn);
                Console.WriteLine("Startpositie is leeg");
            }
            else
            {
                VerschuifLijnen();
                _lijnen.AddFirst(lijn);
            }
        }

        public void VerschuifLijnen()
        {
            foreach(Lijn lijn in _lijnen)
            {
                if(lijn.PositieOpDeKabel >= 9)
                {
                    lijn.PositieOpDeKabel = 0;
                }
                else
                {
                    lijn.PositieOpDeKabel += 1;
                }
            }
        }

        public Lijn VerwijderLijnVanKabel()
        {
            foreach (Lijn lijn in _lijnen)
            {
                if (lijn.PositieOpDeKabel == 9)
                {
                    _lijnen.RemoveLast();
                    return lijn;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string lijnenString = "";
            foreach (Lijn lijn in _lijnen)
            {
                lijnenString += lijn.PositieOpDeKabel + "| ";
                
            }
            return lijnenString;
        }
    }
}
