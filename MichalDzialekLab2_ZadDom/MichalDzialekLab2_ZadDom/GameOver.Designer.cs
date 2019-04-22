namespace MichalDzialekLab2_ZadDom
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameOver.Location = new System.Drawing.Point(175, 187);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(807, 145);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Game Over";
            // 
            // labelReturn
            // 
            this.labelReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.Color.Transparent;
            this.labelReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReturn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReturn.Location = new System.Drawing.Point(286, 454);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(588, 73);
            this.labelReturn.TabIndex = 1;
            this.labelReturn.Text = "Powrót do menu";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 723);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelGameOver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelReturn;
    }
}