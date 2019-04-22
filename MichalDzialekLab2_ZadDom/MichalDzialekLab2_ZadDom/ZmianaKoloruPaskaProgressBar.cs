using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// Klasa kontrolująca dynamiczne zmiany koloru pasku postępu
    /// </summary>
    public static class ZmianaKoloruPaskaProgressBar
    {
        public static void Name(this ProgressBar progressBar)
        {
            //głowny pasek życia
            if(progressBar.Maximum == 20000)
            {
                if (progressBar.Value > 13000)
                {
                    //Kolor zielony
                    DynamicProgressBar.SetState(progressBar, 1);
                }
                else if (progressBar.Value > 7000)
                {
                    //Kolor żółty
                    DynamicProgressBar.SetState(progressBar, 3);
                }
                else if (progressBar.Value < 7000)
                {
                    //Kolor czerwony
                    DynamicProgressBar.SetState(progressBar, 2);
                }
                else if(progressBar.Value == 0)
                {
                    progressBar.Enabled = false;
                }
            }

            //tors
            else if (progressBar.Maximum == 10000)
            {
                if (progressBar.Value > 7000)
                {
                    //Kolor zielony
                    DynamicProgressBar.SetState(progressBar, 1);
                }
                else if (progressBar.Value > 3000)
                {
                    //Kolor żółty
                    DynamicProgressBar.SetState(progressBar, 3);
                }
                else if (progressBar.Value < 3000)
                {
                    //Kolor czerwony
                    DynamicProgressBar.SetState(progressBar, 2);
                }
                else if (progressBar.Value == 0)
                {
                    progressBar.Enabled = false;
                }
            }

            //nogi
            else if(progressBar.Maximum == 5000)
            {
                if (progressBar.Value > 3500)
                {
                    //Kolor zielony
                    DynamicProgressBar.SetState(progressBar, 1);
                }
                else if (progressBar.Value > 1500)
                {
                    //Kolor żółty
                    DynamicProgressBar.SetState(progressBar, 3);
                }
                else if (progressBar.Value < 1500)
                {
                    //Kolor czerwony
                    DynamicProgressBar.SetState(progressBar, 2);
                }
                else if (progressBar.Value == 0)
                {
                    progressBar.Enabled = false;
                }
            }

            //ręce
            else if(progressBar.Maximum == 3000)
            {
                if (progressBar.Value > 2000)
                {
                    //Kolor zielony
                    DynamicProgressBar.SetState(progressBar, 1);
                }
                else if (progressBar.Value > 1000)
                {
                    //Kolor żółty
                    DynamicProgressBar.SetState(progressBar, 3);
                }
                else if (progressBar.Value < 1000)
                {
                    //Kolor czerwony
                    DynamicProgressBar.SetState(progressBar, 2);
                }
                else if (progressBar.Value == 0)
                {
                    progressBar.Enabled = false;
                }
            }

            //głowa
            else if(progressBar.Maximum == 2000)
            {
                if (progressBar.Value > 1400)
                {
                    //Kolor zielony
                    DynamicProgressBar.SetState(progressBar, 1);
                }
                else if (progressBar.Value > 700)
                {
                    //Kolor żółty
                    DynamicProgressBar.SetState(progressBar, 3);
                }
                else if (progressBar.Value < 700)
                {
                    //Kolor czerwony
                    DynamicProgressBar.SetState(progressBar, 2);
                }
                else if (progressBar.Value == 0)
                {
                    progressBar.Enabled = false;
                }
            }
        }
    }
}
