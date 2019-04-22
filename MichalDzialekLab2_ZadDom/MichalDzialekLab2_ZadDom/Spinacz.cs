using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Klasa spinająca mechanizmy główne gry. NIE RUSZAĆ BO SIĘ POPSUJE.
    /// </summary>
    public class Spinacz
    {
        public int Spinka(int iw, int ip)
        {
            if(ip == 0)
            {
                var glowaDmg = new Glowa();
                return glowaDmg.Obrazenia(iw);
            }
            else if(ip == 1)
            {
                var receDmg = new Rece();
                return receDmg.Obrazenia(iw);
            }
            else if (ip == 2)
            {
                var torsDmg = new Tors();
                return torsDmg.Obrazenia(iw);
            }
            else if (ip == 3)
            {
                var nogiDmg = new Nogi();
                return nogiDmg.Obrazenia(iw);
            }
            else if (iw == 0)
            {
                var piesciDmg = new Piesci();
                return piesciDmg.Damage();
            }
            else
            {
                //Niemożliwe do uzyskania z posiadanymi warunkami, no chyba, że użytkownik coś oszuka, 
                //więc dla bezpieczeństwa spowoduje nie zadanie obrażeń
                return 0;
            }
        }
    }
}
