using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Modyfikator obrażeń dla rąk
    /// </summary>
    public class Rece
    {
        public int Obrazenia(int iw)
        {
            if (iw == 0)
            {
                Piesci piesci = new Piesci();
                return piesci.Damage();
            }
            else if (iw == 1)
            {
                Miecz miecz = new Miecz();
                return miecz.Damage() * 2;
            }
            else if (iw == 2)
            {
                Tarcza tarcza = new Tarcza();
                return tarcza.Damage();
            }
            else if (iw == 3)
            {
                Siekiera siekiera = new Siekiera();
                return siekiera.Damage();
            }
            else if (iw == 4)
            {
                Topor topor = new Topor();
                return topor.Damage();
            }
            else
            {
                return 0;
            }
        }

        //Zmiana tesktu w shapebox
        public override string ToString()
        {
            return "Ręce";
        }
    }
}
