﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Watrtość obrażeń dla siekiery
    /// </summary>
    public class Siekiera : DamageBase, IDamage
    {

        //Wartość obrażeń bazowych
        public int basedamage(int damageBase)
        {
            this.damageBase = damagebase;
            return damagebase;
        }

        private int damagebase = 7;


        //Zadawane obrażenia
        public override int Damage()
        {
            return damagebase * 3;
        }

        //Zmiana tesktu w shapebox
        public override string ToString()
        {
            return "Siekiera";
        }
    }
}
