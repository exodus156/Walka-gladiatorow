﻿using System;
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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Powrót do menu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
