using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MichalDzialekLab2_ZadDom
{
    public partial class Walka : Form
    {
        public Walka()
        {
            InitializeComponent();
        }
        /// <summary>
        /// kontrola przycisku start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Przycisk znika
            buttonStart.Enabled = false;
            buttonStart.Visible = false;

            //Startują timery
            timerHealth.Enabled = true;
            timerWeaponType.Enabled = true;
            timerBodyPartHighlight.Enabled = true;
            timerPlayerTurn.Enabled = true;
            timerEndGame.Enabled = true;

            //Pojawiają się obrazki
            pictureBoxEnemy.Visible = true;
            pictureBoxEnemy.Enabled = true;

            pictureBoxAlly.Visible = true;
            pictureBoxAlly.Enabled = true;

            pictureBoxPodzial.Enabled = true;
            pictureBoxPodzial.Visible = true;

            //Pojawiają się opisy
            labelChoosePart.Visible = true;
            labelChoosePart.Enabled = true;

            labelChooseWep.Visible = true;
            labelChooseWep.Enabled = true;

            labelGlowaAlly.Enabled = true;
            labelGlowaAlly.Visible = true;

            labelGlowaEnemy.Enabled = true;
            labelGlowaEnemy.Visible = true;

            labelReceAlly.Visible = true;
            labelReceAlly.Enabled = true;

            labelReceEnemy.Enabled = true;
            labelReceEnemy.Visible = true;

            labelTorsAlly.Enabled = true;
            labelTorsAlly.Visible = true;

            labelTorsEnemy.Enabled = true;
            labelTorsEnemy.Visible = true;

            labelNogiAlly.Enabled = true;
            labelNogiAlly.Visible = true;

            labelNogiEnemy.Enabled = true;
            labelNogiEnemy.Visible = true;

            labelHealthAlly.Enabled = true;
            labelHealthAlly.Visible = true;

            labelHealthEnemy.Enabled = true;
            labelHealthEnemy.Visible = true;

            labelWeapChoose.Visible = true;
            labelWeapChoose.Enabled = true;

            labelPasekSily.Enabled = true;
            labelPasekSily.Visible = true;

            //Pojawia się przycisk i comboboxy
            buttonFight.Visible = true;
            buttonFight.Enabled = true;

            buttonShowAvalibleBParts.Enabled = true;
            buttonShowAvalibleBParts.Visible = true;

            comboBoxPart.Enabled = true;
            comboBoxPart.Visible = true;

            comboBoxWeapon.Enabled = true;
            comboBoxWeapon.Visible = true;

            //Dodają się obiekty do comboboxów

            //Powstają pięści
            Piesci piesci = new Piesci();
            comboBoxWeapon.Items.Add(piesci);
            comboBoxWeapon.SelectedIndex = 0;

            //Powstaje miecz
            Miecz miecz = new Miecz();
            comboBoxWeapon.Items.Add(miecz);

            //Powstaje tarcza
            Tarcza tarcza = new Tarcza();
            comboBoxWeapon.Items.Add(tarcza);

            //Powstaje siekiera
            Siekiera siekiera = new Siekiera();
            comboBoxWeapon.Items.Add(siekiera);

            //Powstaje topór
            Topor topor = new Topor();
            comboBoxWeapon.Items.Add(topor);

            //Powstaje głowa
            Glowa glowa = new Glowa();
            comboBoxPart.Items.Add(glowa);
            comboBoxPart.SelectedIndex = 0;

            //Powstają ręce
            Rece rece = new Rece();
            comboBoxPart.Items.Add(rece);

            //Powstaje tors
            Tors tors = new Tors();
            comboBoxPart.Items.Add(tors);

            //Powstają nogi
            Nogi nogi = new Nogi();
            comboBoxPart.Items.Add(nogi);

            //Pojawiają się progress bary
            progressBarGlowaA.Enabled = true;
            progressBarGlowaA.Visible = true;

            progressBarGlowaE.Enabled = true;
            progressBarGlowaE.Visible = true;

            progressBarNogiA.Enabled = true;
            progressBarNogiA.Visible = true;

            progressBarNogiE.Enabled = true;
            progressBarNogiE.Visible = true;

            progressBarPower.Enabled = true;
            progressBarPower.Visible = true;

            progressBarReceA.Enabled = true;
            progressBarReceA.Visible = true;

            progressBarReceE.Enabled = true;
            progressBarReceE.Visible = true;

            progressBarTorsA.Enabled = true;
            progressBarTorsA.Visible = true;

            progressBarTorsE.Enabled = true;
            progressBarTorsE.Visible = true;

            progressBarZycieA.Enabled = true;
            progressBarZycieA.Visible = true;

            progressBarZycieE.Enabled = true;
            progressBarZycieE.Visible = true;

            //Włącza się timer do listy
            timerListaObecnychCzesciCiala.Enabled = true;
        }

        /// <summary>
        /// Timer sprawdzający życie graczy i zmieniający kolor ich paska życia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHealth_Tick(object sender, EventArgs e)
        {
            //Zmiany koloru
            ZmianaKoloruPaskaProgressBar.Name(progressBarZycieA);
            ZmianaKoloruPaskaProgressBar.Name(progressBarZycieE);
            ZmianaKoloruPaskaProgressBar.Name(progressBarGlowaA);
            ZmianaKoloruPaskaProgressBar.Name(progressBarGlowaE);
            ZmianaKoloruPaskaProgressBar.Name(progressBarTorsA);
            ZmianaKoloruPaskaProgressBar.Name(progressBarTorsE);
            ZmianaKoloruPaskaProgressBar.Name(progressBarReceA);
            ZmianaKoloruPaskaProgressBar.Name(progressBarReceE);
            ZmianaKoloruPaskaProgressBar.Name(progressBarNogiA);
            ZmianaKoloruPaskaProgressBar.Name(progressBarNogiE);

            //Pilnowanie paska żyć
            progressBarZycieA.Value = progressBarTorsA.Value + progressBarReceA.Value + progressBarNogiA.Value + progressBarGlowaA.Value;
            progressBarZycieE.Value = progressBarTorsE.Value + progressBarReceE.Value + progressBarNogiE.Value + progressBarGlowaE.Value;

            progressBarZycieA.Refresh();
            progressBarZycieE.Refresh();
            progressBarGlowaA.Refresh();
            progressBarGlowaE.Refresh();
            progressBarTorsA.Refresh();
            progressBarTorsE.Refresh();
            progressBarReceA.Refresh();
            progressBarReceE.Refresh();
            progressBarNogiA.Refresh();
            progressBarNogiE.Refresh();
        }

        //Licznik siły uderzenia
        int counterSila = 0;

        //Timer zwiększający siłę uderzenia
        private void timerSila_Tick(object sender, EventArgs e)
        {
            if(progressBarPower.Value == 10000)
            {
                timerSila.Enabled = false;
            }
            else
            {
                progressBarPower.Increment(200);
                counterSila += 1;
            }
        }

        //Zwiększanie siły uderzenia po przytrzymaniu przycisku
        private void buttonFight_MouseDown(object sender, MouseEventArgs e)
        {
            counterSila = 1;
            timerSila.Enabled = true;
        }

        //Reakcja na puszczenie przycisku
        private void buttonFight_MouseUp(object sender, MouseEventArgs e)
        {
            timerSila.Enabled = false;

            //Numery indeksów z comboboxów
            int iw = comboBoxWeapon.SelectedIndex;
            int ip = comboBoxPart.SelectedIndex;

            //inicjacja funkcji spinającej
            Spinacz spinacz = new Spinacz();
            int DMGzadany = spinacz.Spinka(iw, ip);

            //zadaje obrażenia
            if (ip == 0)
            {
                progressBarGlowaE.Increment(-(DMGzadany * counterSila));
            }
            else if (ip == 1)
            {
                progressBarReceE.Increment(-(DMGzadany * counterSila));
            }
            else if (ip == 2)
            {
                progressBarTorsE.Increment(-(DMGzadany * counterSila));
            }
            else if (ip == 3)
            {
                progressBarNogiE.Increment(-(DMGzadany * counterSila));
            }

            //reset paska siły
            progressBarPower.Value = 0;

            //zakończenie tury gracza
            counterPlayerTurnTime += 60;
        }

        /// <summary>
        /// Timer kontrolujący obrazki dla broni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWeaponType_Tick(object sender, EventArgs e)
        {
            //Numer indeksu z comboboxa dla broni
            int iw = comboBoxWeapon.SelectedIndex;

            if(iw == 0)
            {
                WeaponSelectedImage image = new WeaponSelectedImage();
                image.Image(pictureBoxWybranaPiesci, pictureBoxWybranaMiecz, pictureBoxWybranaTarcza, pictureBoxWybranaSiekiera, pictureBoxWybranaTopor);
            }
            else if (iw == 1)
            {
                WeaponSelectedImage image = new WeaponSelectedImage();
                image.Image(pictureBoxWybranaMiecz, pictureBoxWybranaPiesci, pictureBoxWybranaTarcza, pictureBoxWybranaSiekiera, pictureBoxWybranaTopor);
            }
            else if (iw == 2)
            {
                WeaponSelectedImage image = new WeaponSelectedImage();
                image.Image(pictureBoxWybranaTarcza, pictureBoxWybranaPiesci, pictureBoxWybranaMiecz, pictureBoxWybranaSiekiera, pictureBoxWybranaTopor);
            }
            else if (iw == 3)
            {
                WeaponSelectedImage image = new WeaponSelectedImage();
                image.Image(pictureBoxWybranaSiekiera, pictureBoxWybranaPiesci, pictureBoxWybranaMiecz, pictureBoxWybranaTarcza, pictureBoxWybranaTopor);
            }
            else if (iw == 4)
            {
                WeaponSelectedImage image = new WeaponSelectedImage();
                image.Image(pictureBoxWybranaTopor, pictureBoxWybranaPiesci, pictureBoxWybranaMiecz, pictureBoxWybranaTarcza, pictureBoxWybranaSiekiera);
            }
        }

        /// <summary>
        /// Timer kontrolujący podświetlanie napisu wybranej części ciała
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBodyPartHighlight_Tick(object sender, EventArgs e)
        {
            //Numer indeksu z comboboxa dla części ciała
            int ip = comboBoxPart.SelectedIndex;

            if(ip == 0)
            {
                BodyPartsHighlight highlight = new BodyPartsHighlight();
                highlight.Highlight(labelGlowaEnemy, labelReceEnemy, labelTorsEnemy, labelNogiEnemy);
            }
            else if (ip == 1)
            {
                BodyPartsHighlight highlight = new BodyPartsHighlight();
                highlight.Highlight(labelReceEnemy, labelGlowaEnemy, labelTorsEnemy, labelNogiEnemy);
            }
            else if (ip == 2)
            {
                BodyPartsHighlight highlight = new BodyPartsHighlight();
                highlight.Highlight(labelTorsEnemy, labelGlowaEnemy, labelReceEnemy, labelNogiEnemy);
            }
            else if (ip == 3)
            {
                BodyPartsHighlight highlight = new BodyPartsHighlight();
                highlight.Highlight(labelNogiEnemy, labelGlowaEnemy, labelReceEnemy, labelTorsEnemy);
            }
        }

        /// <summary>
        /// COunter dla licznika dla tury przeciwnika
        /// </summary>
        int counterEnemyAI = 0;

        /// <summary>
        /// Timer kontrolujący atak przeciwnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnemyAI_Tick(object sender, EventArgs e)
        {
            counterEnemyAI++;
            if (counterEnemyAI == 3)
            {
                //Generuje losową część ciała
                Random randomip = new Random();
                int indexpart = randomip.Next(0, 3);

                //Uruchamia funkcję ataku
                EnemyAI enemy = new EnemyAI();
                int damageEnemy = enemy.Fight(indexpart);

                //Atakuje określoną część ciała
                if(indexpart == 0)
                {
                    progressBarGlowaA.Increment(-(damageEnemy * 75));
                }
                else if(indexpart == 1)
                {
                    progressBarReceA.Increment(-(damageEnemy * 75));
                }
                else if (indexpart == 2)
                {
                    progressBarTorsA.Increment(-(damageEnemy * 75));
                }
                else if (indexpart == 3)
                {
                    progressBarNogiA.Increment(-(damageEnemy * 75));
                }
            }
            else if (counterEnemyAI == 5)
            {
                timerEnemyAI.Enabled = false;
                counterEnemyAI = 0;
                timerPlayerTurn.Enabled = true;
            }
        }

        /// <summary>
        /// Licznik czasu dla tury gracza
        /// </summary>
        int counterPlayerTurnTime = 0;

        /// <summary>
        /// Timer sterujący turą gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlayerTurn_Tick(object sender, EventArgs e)
        {
            if(counterPlayerTurnTime >= 60)
            {
                timerPlayerTurn.Enabled = false;
                buttonFight.Enabled = false;
                counterPlayerTurnTime = 0;
                timerEnemyAI.Enabled = true;
                labelYourTurn.Enabled = false;
                labelYourTurn.Visible = false;
                buttonShowAvalibleBParts.Enabled = false;
            }
            else
            {
                counterPlayerTurnTime++;
                labelYourTurn.Enabled = true;
                labelYourTurn.Visible = true;
                buttonFight.Enabled = true;
                buttonShowAvalibleBParts.Enabled = true;
            }
        }

        /// <summary>
        /// Timer kontrolujący warunki dla końca gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            if(progressBarZycieA.Value <= 100)
            {
                GameOver gameOver = new GameOver();
                gameOver.Show();
                Close();
            }
            else if (progressBarZycieE.Value <= 100)
            {
                Victory victory = new Victory();
                victory.Show();
                Close();
            }
        }

        //Licznik potrzebny do listy części ciała
        int counterListaCzesciCiala = 0;
        List<string> ListaCzesciCiala = new List<string>();

        /// <summary>
        /// Timer kontrolujący listę obecnych części ciała przeciwnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerListaObecnychCzesciCiala_Tick(object sender, EventArgs e)
        {
            counterListaCzesciCiala++;
            if(counterListaCzesciCiala == 1)
            {
                //Aktywuje się lista dostępnych części ciała przeciwnika
                ListaCzesciCiala.Add(labelGlowaEnemy.Text);
                ListaCzesciCiala.Add(labelReceEnemy.Text);
                ListaCzesciCiala.Add(labelTorsEnemy.Text);
                ListaCzesciCiala.Add(labelNogiEnemy.Text);
            }
            else
            {
                if(progressBarGlowaE.Value == 0)
                {
                    ListaCzesciCiala.Remove(labelGlowaEnemy.Text);
                }
                else if(progressBarReceE.Value == 0)
                {
                    ListaCzesciCiala.Remove(labelReceEnemy.Text);
                }
                else if (progressBarTorsE.Value == 0)
                {
                    ListaCzesciCiala.Remove(labelTorsEnemy.Text);
                }
                else if (progressBarNogiE.Value == 0)
                {
                    ListaCzesciCiala.Remove(labelNogiEnemy.Text);
                }
            }
        }

        /// <summary>
        /// Wyświetlenie dostępnych części ciała
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAvalibleBParts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Możliwe do ataku części ciała:");

            // Displaying the elements of List 
            foreach (string part in ListaCzesciCiala)
            {
                MessageBox.Show(part);
            }
        }
    }
}
