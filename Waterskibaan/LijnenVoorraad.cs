using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class LijnenVoorraad
    {
        public Queue<Lijn> _lijnenQueue = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnenQueue.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if (_lijnenQueue != null)
            {
                _lijnenQueue.Dequeue();
                return _lijnenQueue.Peek();
            }
            else
            {
                return null;
            }
            
        }

        public int GetAantalLijnen()
        {
            return _lijnenQueue.Count();
        }

        public override string ToString()
        {
            return $"Aantal lijnen op voorraad: {GetAantalLijnen()}";
        }
    }
}
