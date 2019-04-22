using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Klasa kontrolująca AI przeciwnika
    /// </summary>
    public class EnemyAI
    {
        public int Fight(int indexpart)
        {
            //Generuje losową część ciała i broń
            Random randomiw = new Random();
            Random randomip = new Random();
            int indexweapon = randomiw.Next(0, 4);

            //Randomowy atak
            Spinacz spinacz = new Spinacz();
            return spinacz.Spinka(indexweapon, indexpart);

        }
    }
}
