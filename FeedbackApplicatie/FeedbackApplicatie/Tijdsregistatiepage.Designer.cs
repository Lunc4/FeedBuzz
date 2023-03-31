namespace FeedbackApplicatie
{
    partial class Tijdsregistatiepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tijdsregistatiepage));
            this.label1 = new System.Windows.Forms.Label();
            this.Terug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tijdsregistratie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Terug
            // 
            this.Terug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Terug.AutoSize = true;
            this.Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Terug.Location = new System.Drawing.Point(47, 379);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(53, 26);
            this.Terug.TabIndex = 2;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            // 
            // Tijdsregistatiepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Tijdsregistatiepage";
            this.Text = "Tijdsregistatiepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Terug;
    }
}