using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Wartość obrażeń dla toporu
    /// </summary>
    public class Topor : DamageBase, IDamage
    {
        //Wartość obrażeń bazowych
        public int basedamage(int damageBase)
        {
            this.damageBase = damageBase;
            return damageBase;
        }
        private int damagebase = 8;

        //Zadawane obrażenia
        public override int Damage()
        {
            return damagebase * 2;
        }

        //Zmiana tesktu w shapebox
        public override string ToString()
        {
            return "Topór";
        }
    }
}
