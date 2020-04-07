namespace Russian_Roulette
{
    partial class Form1
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
            this.btnFire = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(130, 50);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(90, 58);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.Location = new System.Drawing.Point(280, 50);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(116, 58);
            this.btnshoot.TabIndex = 1;
            this.btnshoot.Text = "Shoot Away";
            this.btnshoot.UseVisualStyleBackColor = true;
            this.btnshoot.Click += new System.EventHandler(this.btnshoot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Russian_Roulette.Properties.Resources.bow_and_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(54, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btnFire);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

