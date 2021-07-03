namespace Studenci
{
    partial class Searching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searching));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btoksearching = new System.Windows.Forms.Button();
            this.btbacksearching = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(4, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wyszukiwanie  studentów";
            // 
            // btoksearching
            // 
            this.btoksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btoksearching.Image = ((System.Drawing.Image)(resources.GetObject("btoksearching.Image")));
            this.btoksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoksearching.Location = new System.Drawing.Point(129, 376);
            this.btoksearching.Name = "btoksearching";
            this.btoksearching.Size = new System.Drawing.Size(122, 62);
            this.btoksearching.TabIndex = 13;
            this.btoksearching.Text = "OK";
            this.btoksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoksearching.UseVisualStyleBackColor = true;
            this.btoksearching.Click += new System.EventHandler(this.btoksearching_Click);
            // 
            // btbacksearching
            // 
            this.btbacksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btbacksearching.Image = ((System.Drawing.Image)(resources.GetObject("btbacksearching.Image")));
            this.btbacksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbacksearching.Location = new System.Drawing.Point(257, 376);
            this.btbacksearching.Name = "btbacksearching";
            this.btbacksearching.Size = new System.Drawing.Size(122, 62);
            this.btbacksearching.TabIndex = 14;
            this.btbacksearching.Text = "Anuluj";
            this.btbacksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbacksearching.UseVisualStyleBackColor = true;
            this.btbacksearching.Click += new System.EventHandler(this.btbacksearching_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(114, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Podaj numer indeksu studenta";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtid.Location = new System.Drawing.Point(203, 223);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 29);
            this.txtid.TabIndex = 16;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdata.Location = new System.Drawing.Point(118, 282);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(261, 29);
            this.txtdata.TabIndex = 18;
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(114, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Podaj imię i nazwisko studenta";
            // 
            // txtsemester
            // 
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsemester.Location = new System.Drawing.Point(203, 341);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(100, 29);
            this.txtsemester.TabIndex = 20;
            this.txtsemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(143, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Podaj semestr studentów";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(167, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Podaj jedno z kryteriów";
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbacksearching);
            this.Controls.Add(this.btoksearching);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Searching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searching";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoksearching;
        private System.Windows.Forms.Button btbacksearching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}