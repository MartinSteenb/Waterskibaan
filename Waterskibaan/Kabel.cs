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

        public LinkedList<Lijn> getList()
        {
            return _lijnen;
        }

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
                _lijnen.AddFirst(lijn);
                Console.WriteLine("Startpositie is leeg");
            }
        }

        public void VerschuifLijnen()
        {

        }

        public Lijn VerwijderLijnVanKabel()
        {
            if (_lijnen.Count() == 10)
            {
                return _lijnen.Last.Value;
            }
            return null;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
