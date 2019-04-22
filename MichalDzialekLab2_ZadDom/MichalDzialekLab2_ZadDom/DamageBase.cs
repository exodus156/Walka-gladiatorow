using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Abstrakcyjna klasa dla obrażeń podstawowych i funkcji obrażeń
    /// </summary>
    public abstract class DamageBase
    {
        //Stworzenie wartości podstawowej dla obrażeń
        protected int damageBase;

        //Stworzenie funkcji obrażeń
        public abstract int Damage();
    }
}
