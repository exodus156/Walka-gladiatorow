namespace MichalDzialekLab2_ZadDom
{
    partial class PanelGlowny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelGlowny));
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewGame.AutoSize = true;
            this.buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewGame.Location = new System.Drawing.Point(301, 108);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(216, 51);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa Gra";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(328, 312);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(154, 51);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Wyjdź";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHowToPlay.AutoSize = true;
            this.buttonHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHowToPlay.FlatAppearance.BorderSize = 0;
            this.buttonHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowToPlay.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHowToPlay.Location = new System.Drawing.Point(314, 208);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(193, 51);
            this.buttonHowToPlay.TabIndex = 2;
            this.buttonHowToPlay.Text = "Jak Grać";
            this.buttonHowToPlay.UseVisualStyleBackColor = false;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // PanelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelGlowny";
            this.Text = "Walki Gladiatorów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHowToPlay;
    }
}

