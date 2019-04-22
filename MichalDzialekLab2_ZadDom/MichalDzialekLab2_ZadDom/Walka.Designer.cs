namespace MichalDzialekLab2_ZadDom
{
    partial class Walka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Walka));
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxAlly = new System.Windows.Forms.PictureBox();
            this.progressBarGlowaA = new System.Windows.Forms.ProgressBar();
            this.progressBarReceA = new System.Windows.Forms.ProgressBar();
            this.progressBarTorsA = new System.Windows.Forms.ProgressBar();
            this.progressBarNogiA = new System.Windows.Forms.ProgressBar();
            this.progressBarGlowaE = new System.Windows.Forms.ProgressBar();
            this.progressBarReceE = new System.Windows.Forms.ProgressBar();
            this.progressBarTorsE = new System.Windows.Forms.ProgressBar();
            this.progressBarNogiE = new System.Windows.Forms.ProgressBar();
            this.progressBarZycieA = new System.Windows.Forms.ProgressBar();
            this.progressBarZycieE = new System.Windows.Forms.ProgressBar();
            this.pictureBoxPodzial = new System.Windows.Forms.PictureBox();
            this.labelHealthAlly = new System.Windows.Forms.Label();
            this.labelHealthEnemy = new System.Windows.Forms.Label();
            this.labelYourTurn = new System.Windows.Forms.Label();
            this.labelGlowaAlly = new System.Windows.Forms.Label();
            this.labelGlowaEnemy = new System.Windows.Forms.Label();
            this.labelTorsAlly = new System.Windows.Forms.Label();
            this.labelTorsEnemy = new System.Windows.Forms.Label();
            this.labelReceAlly = new System.Windows.Forms.Label();
            this.labelReceEnemy = new System.Windows.Forms.Label();
            this.labelNogiAlly = new System.Windows.Forms.Label();
            this.labelNogiEnemy = new System.Windows.Forms.Label();
            this.labelWeapChoose = new System.Windows.Forms.Label();
            this.pictureBoxWybranaPiesci = new System.Windows.Forms.PictureBox();
            this.pictureBoxWybranaTarcza = new System.Windows.Forms.PictureBox();
            this.pictureBoxWybranaMiecz = new System.Windows.Forms.PictureBox();
            this.pictureBoxWybranaTopor = new System.Windows.Forms.PictureBox();
            this.pictureBoxWybranaSiekiera = new System.Windows.Forms.PictureBox();
            this.labelChooseWep = new System.Windows.Forms.Label();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.labelChoosePart = new System.Windows.Forms.Label();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.labelPasekSily = new System.Windows.Forms.Label();
            this.progressBarPower = new System.Windows.Forms.ProgressBar();
            this.buttonFight = new System.Windows.Forms.Button();
            this.timerHealth = new System.Windows.Forms.Timer(this.components);
            this.timerSila = new System.Windows.Forms.Timer(this.components);
            this.timerWeaponType = new System.Windows.Forms.Timer(this.components);
            this.timerBodyPartHighlight = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyAI = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerTurn = new System.Windows.Forms.Timer(this.components);
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.timerListaObecnychCzesciCiala = new System.Windows.Forms.Timer(this.components);
            this.buttonShowAvalibleBParts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodzial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaPiesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaTarcza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaMiecz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaTopor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaSiekiera)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Gladiator_Przeciwnik;
            this.pictureBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnemy.Enabled = false;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(1017, 126);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(377, 494);
            this.pictureBoxEnemy.TabIndex = 0;
            this.pictureBoxEnemy.TabStop = false;
            this.pictureBoxEnemy.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(639, 388);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(407, 155);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxAlly
            // 
            this.pictureBoxAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAlly.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlly.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Gladiator_Sojusznik;
            this.pictureBoxAlly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlly.Enabled = false;
            this.pictureBoxAlly.Location = new System.Drawing.Point(256, 126);
            this.pictureBoxAlly.Name = "pictureBoxAlly";
            this.pictureBoxAlly.Size = new System.Drawing.Size(377, 494);
            this.pictureBoxAlly.TabIndex = 2;
            this.pictureBoxAlly.TabStop = false;
            this.pictureBoxAlly.Visible = false;
            // 
            // progressBarGlowaA
            // 
            this.progressBarGlowaA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarGlowaA.Enabled = false;
            this.progressBarGlowaA.Location = new System.Drawing.Point(513, 97);
            this.progressBarGlowaA.Maximum = 2000;
            this.progressBarGlowaA.Name = "progressBarGlowaA";
            this.progressBarGlowaA.Size = new System.Drawing.Size(100, 23);
            this.progressBarGlowaA.Step = 1;
            this.progressBarGlowaA.TabIndex = 3;
            this.progressBarGlowaA.Value = 2000;
            this.progressBarGlowaA.Visible = false;
            // 
            // progressBarReceA
            // 
            this.progressBarReceA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarReceA.Enabled = false;
            this.progressBarReceA.Location = new System.Drawing.Point(639, 258);
            this.progressBarReceA.Maximum = 3000;
            this.progressBarReceA.Name = "progressBarReceA";
            this.progressBarReceA.Size = new System.Drawing.Size(100, 23);
            this.progressBarReceA.Step = 1;
            this.progressBarReceA.TabIndex = 4;
            this.progressBarReceA.Value = 3000;
            this.progressBarReceA.Visible = false;
            // 
            // progressBarTorsA
            // 
            this.progressBarTorsA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarTorsA.Enabled = false;
            this.progressBarTorsA.Location = new System.Drawing.Point(639, 435);
            this.progressBarTorsA.Maximum = 10000;
            this.progressBarTorsA.Name = "progressBarTorsA";
            this.progressBarTorsA.Size = new System.Drawing.Size(100, 23);
            this.progressBarTorsA.Step = 1;
            this.progressBarTorsA.TabIndex = 5;
            this.progressBarTorsA.Value = 10000;
            this.progressBarTorsA.Visible = false;
            // 
            // progressBarNogiA
            // 
            this.progressBarNogiA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarNogiA.Enabled = false;
            this.progressBarNogiA.Location = new System.Drawing.Point(639, 577);
            this.progressBarNogiA.Maximum = 5000;
            this.progressBarNogiA.Name = "progressBarNogiA";
            this.progressBarNogiA.Size = new System.Drawing.Size(100, 23);
            this.progressBarNogiA.Step = 1;
            this.progressBarNogiA.TabIndex = 6;
            this.progressBarNogiA.Value = 5000;
            this.progressBarNogiA.Visible = false;
            // 
            // progressBarGlowaE
            // 
            this.progressBarGlowaE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarGlowaE.Enabled = false;
            this.progressBarGlowaE.Location = new System.Drawing.Point(1276, 97);
            this.progressBarGlowaE.Maximum = 2000;
            this.progressBarGlowaE.Name = "progressBarGlowaE";
            this.progressBarGlowaE.Size = new System.Drawing.Size(100, 23);
            this.progressBarGlowaE.Step = 1;
            this.progressBarGlowaE.TabIndex = 7;
            this.progressBarGlowaE.Value = 2000;
            this.progressBarGlowaE.Visible = false;
            // 
            // progressBarReceE
            // 
            this.progressBarReceE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarReceE.Enabled = false;
            this.progressBarReceE.Location = new System.Drawing.Point(1400, 258);
            this.progressBarReceE.Maximum = 3000;
            this.progressBarReceE.Name = "progressBarReceE";
            this.progressBarReceE.Size = new System.Drawing.Size(100, 23);
            this.progressBarReceE.Step = 1;
            this.progressBarReceE.TabIndex = 8;
            this.progressBarReceE.Value = 3000;
            this.progressBarReceE.Visible = false;
            // 
            // progressBarTorsE
            // 
            this.progressBarTorsE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarTorsE.Enabled = false;
            this.progressBarTorsE.Location = new System.Drawing.Point(1400, 435);
            this.progressBarTorsE.Maximum = 10000;
            this.progressBarTorsE.Name = "progressBarTorsE";
            this.progressBarTorsE.Size = new System.Drawing.Size(100, 23);
            this.progressBarTorsE.Step = 1;
            this.progressBarTorsE.TabIndex = 9;
            this.progressBarTorsE.Value = 10000;
            this.progressBarTorsE.Visible = false;
            // 
            // progressBarNogiE
            // 
            this.progressBarNogiE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarNogiE.Enabled = false;
            this.progressBarNogiE.Location = new System.Drawing.Point(1400, 577);
            this.progressBarNogiE.Maximum = 5000;
            this.progressBarNogiE.Name = "progressBarNogiE";
            this.progressBarNogiE.Size = new System.Drawing.Size(100, 23);
            this.progressBarNogiE.Step = 1;
            this.progressBarNogiE.TabIndex = 10;
            this.progressBarNogiE.Value = 5000;
            this.progressBarNogiE.Visible = false;
            // 
            // progressBarZycieA
            // 
            this.progressBarZycieA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarZycieA.Enabled = false;
            this.progressBarZycieA.Location = new System.Drawing.Point(310, 713);
            this.progressBarZycieA.Maximum = 20000;
            this.progressBarZycieA.Name = "progressBarZycieA";
            this.progressBarZycieA.Size = new System.Drawing.Size(303, 50);
            this.progressBarZycieA.Step = 1;
            this.progressBarZycieA.TabIndex = 11;
            this.progressBarZycieA.Visible = false;
            // 
            // progressBarZycieE
            // 
            this.progressBarZycieE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarZycieE.Enabled = false;
            this.progressBarZycieE.Location = new System.Drawing.Point(1073, 713);
            this.progressBarZycieE.Maximum = 20000;
            this.progressBarZycieE.Name = "progressBarZycieE";
            this.progressBarZycieE.Size = new System.Drawing.Size(303, 50);
            this.progressBarZycieE.Step = 11;
            this.progressBarZycieE.TabIndex = 12;
            this.progressBarZycieE.Visible = false;
            // 
            // pictureBoxPodzial
            // 
            this.pictureBoxPodzial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPodzial.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPodzial.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Podzial;
            this.pictureBoxPodzial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPodzial.Enabled = false;
            this.pictureBoxPodzial.Location = new System.Drawing.Point(804, 68);
            this.pictureBoxPodzial.Name = "pictureBoxPodzial";
            this.pictureBoxPodzial.Size = new System.Drawing.Size(100, 695);
            this.pictureBoxPodzial.TabIndex = 13;
            this.pictureBoxPodzial.TabStop = false;
            this.pictureBoxPodzial.Visible = false;
            // 
            // labelHealthAlly
            // 
            this.labelHealthAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHealthAlly.AutoSize = true;
            this.labelHealthAlly.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthAlly.Enabled = false;
            this.labelHealthAlly.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHealthAlly.Location = new System.Drawing.Point(358, 676);
            this.labelHealthAlly.Name = "labelHealthAlly";
            this.labelHealthAlly.Size = new System.Drawing.Size(213, 34);
            this.labelHealthAlly.TabIndex = 14;
            this.labelHealthAlly.Text = "Pasek Życia:";
            this.labelHealthAlly.Visible = false;
            // 
            // labelHealthEnemy
            // 
            this.labelHealthEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHealthEnemy.AutoSize = true;
            this.labelHealthEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthEnemy.Enabled = false;
            this.labelHealthEnemy.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHealthEnemy.Location = new System.Drawing.Point(1118, 676);
            this.labelHealthEnemy.Name = "labelHealthEnemy";
            this.labelHealthEnemy.Size = new System.Drawing.Size(213, 34);
            this.labelHealthEnemy.TabIndex = 15;
            this.labelHealthEnemy.Text = "Pasek Życia:";
            this.labelHealthEnemy.Visible = false;
            // 
            // labelYourTurn
            // 
            this.labelYourTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYourTurn.AutoSize = true;
            this.labelYourTurn.BackColor = System.Drawing.Color.Transparent;
            this.labelYourTurn.Enabled = false;
            this.labelYourTurn.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourTurn.Location = new System.Drawing.Point(733, 795);
            this.labelYourTurn.Name = "labelYourTurn";
            this.labelYourTurn.Size = new System.Drawing.Size(260, 46);
            this.labelYourTurn.TabIndex = 16;
            this.labelYourTurn.Text = "Twój ruch !";
            this.labelYourTurn.Visible = false;
            // 
            // labelGlowaAlly
            // 
            this.labelGlowaAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGlowaAlly.AutoSize = true;
            this.labelGlowaAlly.BackColor = System.Drawing.Color.Transparent;
            this.labelGlowaAlly.Enabled = false;
            this.labelGlowaAlly.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGlowaAlly.Location = new System.Drawing.Point(511, 66);
            this.labelGlowaAlly.Name = "labelGlowaAlly";
            this.labelGlowaAlly.Size = new System.Drawing.Size(90, 26);
            this.labelGlowaAlly.TabIndex = 17;
            this.labelGlowaAlly.Text = "Głowa";
            this.labelGlowaAlly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGlowaAlly.Visible = false;
            // 
            // labelGlowaEnemy
            // 
            this.labelGlowaEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGlowaEnemy.AutoSize = true;
            this.labelGlowaEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelGlowaEnemy.Enabled = false;
            this.labelGlowaEnemy.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGlowaEnemy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGlowaEnemy.Location = new System.Drawing.Point(1274, 66);
            this.labelGlowaEnemy.Name = "labelGlowaEnemy";
            this.labelGlowaEnemy.Size = new System.Drawing.Size(90, 26);
            this.labelGlowaEnemy.TabIndex = 18;
            this.labelGlowaEnemy.Text = "Głowa";
            this.labelGlowaEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGlowaEnemy.Visible = false;
            // 
            // labelTorsAlly
            // 
            this.labelTorsAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTorsAlly.AutoSize = true;
            this.labelTorsAlly.BackColor = System.Drawing.Color.Transparent;
            this.labelTorsAlly.Enabled = false;
            this.labelTorsAlly.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTorsAlly.Location = new System.Drawing.Point(651, 404);
            this.labelTorsAlly.Name = "labelTorsAlly";
            this.labelTorsAlly.Size = new System.Drawing.Size(66, 26);
            this.labelTorsAlly.TabIndex = 19;
            this.labelTorsAlly.Text = "Tors";
            this.labelTorsAlly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTorsAlly.Visible = false;
            // 
            // labelTorsEnemy
            // 
            this.labelTorsEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTorsEnemy.AutoSize = true;
            this.labelTorsEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelTorsEnemy.Enabled = false;
            this.labelTorsEnemy.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTorsEnemy.Location = new System.Drawing.Point(1412, 404);
            this.labelTorsEnemy.Name = "labelTorsEnemy";
            this.labelTorsEnemy.Size = new System.Drawing.Size(66, 26);
            this.labelTorsEnemy.TabIndex = 20;
            this.labelTorsEnemy.Text = "Tors";
            this.labelTorsEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTorsEnemy.Visible = false;
            // 
            // labelReceAlly
            // 
            this.labelReceAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReceAlly.AutoSize = true;
            this.labelReceAlly.BackColor = System.Drawing.Color.Transparent;
            this.labelReceAlly.Enabled = false;
            this.labelReceAlly.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReceAlly.Location = new System.Drawing.Point(651, 227);
            this.labelReceAlly.Name = "labelReceAlly";
            this.labelReceAlly.Size = new System.Drawing.Size(72, 26);
            this.labelReceAlly.TabIndex = 21;
            this.labelReceAlly.Text = "Ręce";
            this.labelReceAlly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReceAlly.Visible = false;
            // 
            // labelReceEnemy
            // 
            this.labelReceEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReceEnemy.AutoSize = true;
            this.labelReceEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelReceEnemy.Enabled = false;
            this.labelReceEnemy.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReceEnemy.Location = new System.Drawing.Point(1412, 227);
            this.labelReceEnemy.Name = "labelReceEnemy";
            this.labelReceEnemy.Size = new System.Drawing.Size(72, 26);
            this.labelReceEnemy.TabIndex = 22;
            this.labelReceEnemy.Text = "Ręce";
            this.labelReceEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReceEnemy.Visible = false;
            // 
            // labelNogiAlly
            // 
            this.labelNogiAlly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNogiAlly.AutoSize = true;
            this.labelNogiAlly.BackColor = System.Drawing.Color.Transparent;
            this.labelNogiAlly.Enabled = false;
            this.labelNogiAlly.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNogiAlly.Location = new System.Drawing.Point(654, 546);
            this.labelNogiAlly.Name = "labelNogiAlly";
            this.labelNogiAlly.Size = new System.Drawing.Size(69, 26);
            this.labelNogiAlly.TabIndex = 23;
            this.labelNogiAlly.Text = "Nogi";
            this.labelNogiAlly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNogiAlly.Visible = false;
            // 
            // labelNogiEnemy
            // 
            this.labelNogiEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNogiEnemy.AutoSize = true;
            this.labelNogiEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelNogiEnemy.Enabled = false;
            this.labelNogiEnemy.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNogiEnemy.Location = new System.Drawing.Point(1415, 546);
            this.labelNogiEnemy.Name = "labelNogiEnemy";
            this.labelNogiEnemy.Size = new System.Drawing.Size(69, 26);
            this.labelNogiEnemy.TabIndex = 24;
            this.labelNogiEnemy.Text = "Nogi";
            this.labelNogiEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNogiEnemy.Visible = false;
            // 
            // labelWeapChoose
            // 
            this.labelWeapChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWeapChoose.BackColor = System.Drawing.Color.Transparent;
            this.labelWeapChoose.Enabled = false;
            this.labelWeapChoose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeapChoose.Location = new System.Drawing.Point(12, 9);
            this.labelWeapChoose.Name = "labelWeapChoose";
            this.labelWeapChoose.Size = new System.Drawing.Size(167, 83);
            this.labelWeapChoose.TabIndex = 25;
            this.labelWeapChoose.Text = "Wybrana broń:";
            this.labelWeapChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWeapChoose.Visible = false;
            // 
            // pictureBoxWybranaPiesci
            // 
            this.pictureBoxWybranaPiesci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWybranaPiesci.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWybranaPiesci.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.gladiator_bronie_piesci;
            this.pictureBoxWybranaPiesci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWybranaPiesci.Enabled = false;
            this.pictureBoxWybranaPiesci.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxWybranaPiesci.Name = "pictureBoxWybranaPiesci";
            this.pictureBoxWybranaPiesci.Size = new System.Drawing.Size(131, 95);
            this.pictureBoxWybranaPiesci.TabIndex = 26;
            this.pictureBoxWybranaPiesci.TabStop = false;
            this.pictureBoxWybranaPiesci.Visible = false;
            // 
            // pictureBoxWybranaTarcza
            // 
            this.pictureBoxWybranaTarcza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWybranaTarcza.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWybranaTarcza.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.gladiator_bronie_tarcza;
            this.pictureBoxWybranaTarcza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWybranaTarcza.Enabled = false;
            this.pictureBoxWybranaTarcza.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxWybranaTarcza.Name = "pictureBoxWybranaTarcza";
            this.pictureBoxWybranaTarcza.Size = new System.Drawing.Size(131, 95);
            this.pictureBoxWybranaTarcza.TabIndex = 27;
            this.pictureBoxWybranaTarcza.TabStop = false;
            this.pictureBoxWybranaTarcza.Visible = false;
            // 
            // pictureBoxWybranaMiecz
            // 
            this.pictureBoxWybranaMiecz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWybranaMiecz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWybranaMiecz.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.gladiator_bronie_miecz;
            this.pictureBoxWybranaMiecz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWybranaMiecz.Enabled = false;
            this.pictureBoxWybranaMiecz.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxWybranaMiecz.Name = "pictureBoxWybranaMiecz";
            this.pictureBoxWybranaMiecz.Size = new System.Drawing.Size(131, 95);
            this.pictureBoxWybranaMiecz.TabIndex = 28;
            this.pictureBoxWybranaMiecz.TabStop = false;
            this.pictureBoxWybranaMiecz.Visible = false;
            // 
            // pictureBoxWybranaTopor
            // 
            this.pictureBoxWybranaTopor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWybranaTopor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWybranaTopor.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.gladiator_bronie_topor;
            this.pictureBoxWybranaTopor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWybranaTopor.Enabled = false;
            this.pictureBoxWybranaTopor.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxWybranaTopor.Name = "pictureBoxWybranaTopor";
            this.pictureBoxWybranaTopor.Size = new System.Drawing.Size(131, 95);
            this.pictureBoxWybranaTopor.TabIndex = 29;
            this.pictureBoxWybranaTopor.TabStop = false;
            this.pictureBoxWybranaTopor.Visible = false;
            // 
            // pictureBoxWybranaSiekiera
            // 
            this.pictureBoxWybranaSiekiera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWybranaSiekiera.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWybranaSiekiera.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.gladiator_bronie_siekiera;
            this.pictureBoxWybranaSiekiera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWybranaSiekiera.Enabled = false;
            this.pictureBoxWybranaSiekiera.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxWybranaSiekiera.Name = "pictureBoxWybranaSiekiera";
            this.pictureBoxWybranaSiekiera.Size = new System.Drawing.Size(131, 95);
            this.pictureBoxWybranaSiekiera.TabIndex = 30;
            this.pictureBoxWybranaSiekiera.TabStop = false;
            this.pictureBoxWybranaSiekiera.Visible = false;
            // 
            // labelChooseWep
            // 
            this.labelChooseWep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChooseWep.AutoSize = true;
            this.labelChooseWep.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseWep.Enabled = false;
            this.labelChooseWep.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseWep.Location = new System.Drawing.Point(12, 161);
            this.labelChooseWep.Name = "labelChooseWep";
            this.labelChooseWep.Size = new System.Drawing.Size(239, 34);
            this.labelChooseWep.TabIndex = 31;
            this.labelChooseWep.Text = "Wybierz broń:";
            this.labelChooseWep.Visible = false;
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxWeapon.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWeapon.Enabled = false;
            this.comboBoxWeapon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Location = new System.Drawing.Point(12, 214);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(226, 33);
            this.comboBoxWeapon.TabIndex = 32;
            this.comboBoxWeapon.Visible = false;
            // 
            // labelChoosePart
            // 
            this.labelChoosePart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChoosePart.AutoSize = true;
            this.labelChoosePart.BackColor = System.Drawing.Color.Transparent;
            this.labelChoosePart.Enabled = false;
            this.labelChoosePart.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoosePart.Location = new System.Drawing.Point(12, 318);
            this.labelChoosePart.Name = "labelChoosePart";
            this.labelChoosePart.Size = new System.Drawing.Size(211, 34);
            this.labelChoosePart.TabIndex = 33;
            this.labelChoosePart.Text = "Wybierz cel:";
            this.labelChoosePart.Visible = false;
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPart.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPart.Enabled = false;
            this.comboBoxPart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(12, 367);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(226, 33);
            this.comboBoxPart.TabIndex = 34;
            this.comboBoxPart.Visible = false;
            // 
            // labelPasekSily
            // 
            this.labelPasekSily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasekSily.BackColor = System.Drawing.Color.Transparent;
            this.labelPasekSily.Enabled = false;
            this.labelPasekSily.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasekSily.Location = new System.Drawing.Point(25, 435);
            this.labelPasekSily.Name = "labelPasekSily";
            this.labelPasekSily.Size = new System.Drawing.Size(185, 68);
            this.labelPasekSily.TabIndex = 35;
            this.labelPasekSily.Text = "Siła uderzenia:";
            this.labelPasekSily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPasekSily.Visible = false;
            // 
            // progressBarPower
            // 
            this.progressBarPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarPower.Enabled = false;
            this.progressBarPower.Location = new System.Drawing.Point(8, 522);
            this.progressBarPower.Maximum = 10000;
            this.progressBarPower.Name = "progressBarPower";
            this.progressBarPower.Size = new System.Drawing.Size(230, 50);
            this.progressBarPower.Step = 1;
            this.progressBarPower.TabIndex = 36;
            this.progressBarPower.Visible = false;
            // 
            // buttonFight
            // 
            this.buttonFight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFight.BackColor = System.Drawing.Color.Transparent;
            this.buttonFight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFight.Enabled = false;
            this.buttonFight.FlatAppearance.BorderSize = 0;
            this.buttonFight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFight.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFight.Location = new System.Drawing.Point(12, 578);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(226, 171);
            this.buttonFight.TabIndex = 37;
            this.buttonFight.Text = "Naciśnij i przytrzymaj aby wzmocnić atak";
            this.buttonFight.UseVisualStyleBackColor = false;
            this.buttonFight.Visible = false;
            this.buttonFight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFight_MouseDown);
            this.buttonFight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFight_MouseUp);
            // 
            // timerHealth
            // 
            this.timerHealth.Interval = 1;
            this.timerHealth.Tick += new System.EventHandler(this.timerHealth_Tick);
            // 
            // timerSila
            // 
            this.timerSila.Tick += new System.EventHandler(this.timerSila_Tick);
            // 
            // timerWeaponType
            // 
            this.timerWeaponType.Interval = 10;
            this.timerWeaponType.Tick += new System.EventHandler(this.timerWeaponType_Tick);
            // 
            // timerBodyPartHighlight
            // 
            this.timerBodyPartHighlight.Interval = 10;
            this.timerBodyPartHighlight.Tick += new System.EventHandler(this.timerBodyPartHighlight_Tick);
            // 
            // timerEnemyAI
            // 
            this.timerEnemyAI.Interval = 1000;
            this.timerEnemyAI.Tick += new System.EventHandler(this.timerEnemyAI_Tick);
            // 
            // timerPlayerTurn
            // 
            this.timerPlayerTurn.Interval = 1000;
            this.timerPlayerTurn.Tick += new System.EventHandler(this.timerPlayerTurn_Tick);
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 1000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // timerListaObecnychCzesciCiala
            // 
            this.timerListaObecnychCzesciCiala.Tick += new System.EventHandler(this.timerListaObecnychCzesciCiala_Tick);
            // 
            // buttonShowAvalibleBParts
            // 
            this.buttonShowAvalibleBParts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowAvalibleBParts.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowAvalibleBParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAvalibleBParts.Enabled = false;
            this.buttonShowAvalibleBParts.FlatAppearance.BorderSize = 0;
            this.buttonShowAvalibleBParts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShowAvalibleBParts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonShowAvalibleBParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAvalibleBParts.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAvalibleBParts.Location = new System.Drawing.Point(8, 745);
            this.buttonShowAvalibleBParts.Name = "buttonShowAvalibleBParts";
            this.buttonShowAvalibleBParts.Size = new System.Drawing.Size(243, 119);
            this.buttonShowAvalibleBParts.TabIndex = 38;
            this.buttonShowAvalibleBParts.Text = "Pokaż możliwe do ataku części ciała\r\n";
            this.buttonShowAvalibleBParts.UseVisualStyleBackColor = false;
            this.buttonShowAvalibleBParts.Visible = false;
            this.buttonShowAvalibleBParts.Click += new System.EventHandler(this.buttonShowAvalibleBParts_Click);
            // 
            // Walka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1606, 876);
            this.Controls.Add(this.buttonShowAvalibleBParts);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.progressBarPower);
            this.Controls.Add(this.labelPasekSily);
            this.Controls.Add(this.comboBoxPart);
            this.Controls.Add(this.labelChoosePart);
            this.Controls.Add(this.comboBoxWeapon);
            this.Controls.Add(this.labelChooseWep);
            this.Controls.Add(this.pictureBoxWybranaSiekiera);
            this.Controls.Add(this.pictureBoxWybranaTopor);
            this.Controls.Add(this.pictureBoxWybranaMiecz);
            this.Controls.Add(this.pictureBoxWybranaTarcza);
            this.Controls.Add(this.pictureBoxWybranaPiesci);
            this.Controls.Add(this.labelWeapChoose);
            this.Controls.Add(this.labelNogiEnemy);
            this.Controls.Add(this.labelNogiAlly);
            this.Controls.Add(this.labelReceEnemy);
            this.Controls.Add(this.labelReceAlly);
            this.Controls.Add(this.labelTorsEnemy);
            this.Controls.Add(this.labelTorsAlly);
            this.Controls.Add(this.labelGlowaEnemy);
            this.Controls.Add(this.labelGlowaAlly);
            this.Controls.Add(this.labelYourTurn);
            this.Controls.Add(this.labelHealthEnemy);
            this.Controls.Add(this.labelHealthAlly);
            this.Controls.Add(this.pictureBoxPodzial);
            this.Controls.Add(this.progressBarZycieE);
            this.Controls.Add(this.progressBarZycieA);
            this.Controls.Add(this.progressBarNogiE);
            this.Controls.Add(this.progressBarTorsE);
            this.Controls.Add(this.progressBarReceE);
            this.Controls.Add(this.progressBarGlowaE);
            this.Controls.Add(this.progressBarNogiA);
            this.Controls.Add(this.progressBarTorsA);
            this.Controls.Add(this.progressBarReceA);
            this.Controls.Add(this.progressBarGlowaA);
            this.Controls.Add(this.pictureBoxAlly);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Walka";
            this.Text = "Walka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodzial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaPiesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaTarcza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaMiecz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaTopor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWybranaSiekiera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxAlly;
        private System.Windows.Forms.ProgressBar progressBarGlowaA;
        private System.Windows.Forms.ProgressBar progressBarReceA;
        private System.Windows.Forms.ProgressBar progressBarTorsA;
        private System.Windows.Forms.ProgressBar progressBarNogiA;
        private System.Windows.Forms.ProgressBar progressBarGlowaE;
        private System.Windows.Forms.ProgressBar progressBarReceE;
        private System.Windows.Forms.ProgressBar progressBarTorsE;
        private System.Windows.Forms.ProgressBar progressBarNogiE;
        private System.Windows.Forms.ProgressBar progressBarZycieA;
        private System.Windows.Forms.ProgressBar progressBarZycieE;
        private System.Windows.Forms.PictureBox pictureBoxPodzial;
        private System.Windows.Forms.Label labelHealthAlly;
        private System.Windows.Forms.Label labelHealthEnemy;
        private System.Windows.Forms.Label labelYourTurn;
        private System.Windows.Forms.Label labelGlowaAlly;
        private System.Windows.Forms.Label labelGlowaEnemy;
        private System.Windows.Forms.Label labelTorsAlly;
        private System.Windows.Forms.Label labelTorsEnemy;
        private System.Windows.Forms.Label labelReceAlly;
        private System.Windows.Forms.Label labelReceEnemy;
        private System.Windows.Forms.Label labelNogiAlly;
        private System.Windows.Forms.Label labelNogiEnemy;
        private System.Windows.Forms.Label labelWeapChoose;
        private System.Windows.Forms.PictureBox pictureBoxWybranaPiesci;
        private System.Windows.Forms.PictureBox pictureBoxWybranaTarcza;
        private System.Windows.Forms.PictureBox pictureBoxWybranaMiecz;
        private System.Windows.Forms.PictureBox pictureBoxWybranaTopor;
        private System.Windows.Forms.PictureBox pictureBoxWybranaSiekiera;
        private System.Windows.Forms.Label labelChooseWep;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.Label labelChoosePart;
        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.Label labelPasekSily;
        private System.Windows.Forms.ProgressBar progressBarPower;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Timer timerHealth;
        private System.Windows.Forms.Timer timerSila;
        private System.Windows.Forms.Timer timerWeaponType;
        private System.Windows.Forms.Timer timerBodyPartHighlight;
        private System.Windows.Forms.Timer timerEnemyAI;
        private System.Windows.Forms.Timer timerPlayerTurn;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer timerListaObecnychCzesciCiala;
        private System.Windows.Forms.Button buttonShowAvalibleBParts;
    }
}