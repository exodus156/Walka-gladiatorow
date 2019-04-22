namespace MichalDzialekLab2_ZadDom
{
    partial class Victory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victory));
            this.labelVictory = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVictory
            // 
            this.labelVictory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVictory.AutoSize = true;
            this.labelVictory.BackColor = System.Drawing.Color.Transparent;
            this.labelVictory.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVictory.Location = new System.Drawing.Point(262, 146);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(589, 145);
            this.labelVictory.TabIndex = 1;
            this.labelVictory.Text = "Victory!";
            // 
            // labelReturn
            // 
            this.labelReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.Color.Transparent;
            this.labelReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReturn.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReturn.Location = new System.Drawing.Point(263, 431);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(588, 73);
            this.labelReturn.TabIndex = 2;
            this.labelReturn.Text = "Powrót do menu";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab2_ZadDom.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 703);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelVictory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Victory";
            this.Text = "Victory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Label labelReturn;
    }
}