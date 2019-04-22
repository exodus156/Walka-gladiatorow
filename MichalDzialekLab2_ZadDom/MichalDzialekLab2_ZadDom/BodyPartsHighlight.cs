using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MichalDzialekLab2_ZadDom
{
    /// <summary>
    /// klasa kontrolująca podświetlanie wybranych części ciała
    /// </summary>
    public class BodyPartsHighlight
    {
        public void Highlight(Label a, Label b, Label c, Label d)
        {
            a.ForeColor = Color.Red;

            b.ForeColor = Color.Black;
            c.ForeColor = Color.Black;
            d.ForeColor = Color.Black;
        }
    }
}
