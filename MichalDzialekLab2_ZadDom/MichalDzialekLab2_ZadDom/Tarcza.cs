using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Klasa obrażeń dla Tarczy
    /// </summary>
    public class Tarcza : DamageBase, IDamage
    {
        //Wartość obrażeń bazowych
        public int basedamage(int damageBase)
        {
            this.damageBase = damagebase;
            return damagebase;
        }

        private int damagebase = 6;

        //Zadawane obrażenia
        public override int Damage()
        {
            return damagebase * 4;
        }

        //Zmiana tesktu w shapebox
        public override string ToString()
        {
            return "Tarcza";
        }
    }
}
