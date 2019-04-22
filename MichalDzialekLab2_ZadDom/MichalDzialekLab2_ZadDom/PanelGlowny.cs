using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalDzialekLab2_ZadDom
{
    public partial class PanelGlowny : Form
    {
        public PanelGlowny()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kontrola przycisku zamknij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Kontrola przycisku Jak Grać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay howToPlay = new HowToPlay();
            howToPlay.Show();
        }

        /// <summary>
        /// Kontrola przycisku Nowa Gra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Walka walka = new Walka();
            walka.Show();
        }
    }
}
