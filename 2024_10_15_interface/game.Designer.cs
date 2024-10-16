
namespace _2024_10_15_interface
{
    partial class game
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
            this.label1 = new System.Windows.Forms.Label();
            this.road = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1027, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // road
            // 
            this.road.BorderRadius = 10;
            this.road.ImageRotate = 0F;
            this.road.Location = new System.Drawing.Point(1, 216);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(1199, 200);
            this.road.TabIndex = 2;
            this.road.TabStop = false;
            this.road.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BorderRadius = 10;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(599, -1);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(172, 601);
            this.guna2PictureBox3.TabIndex = 3;
            this.guna2PictureBox3.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.road);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox road;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}