using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalDzialekLab2_ZadDom
{
    //Klasa kontrolująca obrazki dla broni
    public class WeaponSelectedImage
    {
        public void Image(PictureBox a, PictureBox b, PictureBox c, PictureBox d, PictureBox e)
        {
            a.Enabled = true;
            a.Visible = true;

            b.Enabled = false;
            b.Visible = false;

            c.Enabled = false;
            c.Visible = false;

            d.Enabled = false;
            d.Visible = false;

            e.Enabled = false;
            e.Visible = false;
        }
    }
}
