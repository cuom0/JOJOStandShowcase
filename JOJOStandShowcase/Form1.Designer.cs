namespace JOJOStandShowcase
{
    partial class JoJoMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoJoMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.showcase = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JOJOStandShowcase.Properties.Resources.gradient;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::JOJOStandShowcase.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 189);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 225);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JOJOStandShowcase.Properties.Resources.logo2;
            this.pictureBox3.Location = new System.Drawing.Point(352, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(448, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // showcase
            // 
            this.showcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showcase.Image = global::JOJOStandShowcase.Properties.Resources.showcase;
            this.showcase.Location = new System.Drawing.Point(24, 262);
            this.showcase.Name = "showcase";
            this.showcase.Size = new System.Drawing.Size(260, 260);
            this.showcase.TabIndex = 3;
            this.showcase.UseVisualStyleBackColor = true;
            // 
            // Credits
            // 
            this.Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credits.Image = global::JOJOStandShowcase.Properties.Resources.credits;
            this.Credits.Location = new System.Drawing.Point(352, 262);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(400, 260);
            this.Credits.TabIndex = 4;
            this.Credits.UseVisualStyleBackColor = true;
            this.Credits.Click += new System.EventHandler(this.button1_Click);
            // 
            // JoJoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.showcase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JoJoMenu";
            this.Text = "JoJo\'s Bizarre Adventure: STAND SHOWCASE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button showcase;
        private Button Credits;
    }
}