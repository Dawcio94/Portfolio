namespace Studenci
{
    partial class Detailsediting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailsediting));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btbacksearching = new System.Windows.Forms.Button();
            this.btoksearching = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btdegrees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(205, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 45;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(143, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numer indeksu studenta";
            // 
            // txtsemester
            // 
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsemester.Location = new System.Drawing.Point(205, 290);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(100, 29);
            this.txtsemester.TabIndex = 43;
            this.txtsemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(173, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Semestr studenta";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdata.Location = new System.Drawing.Point(120, 231);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(261, 29);
            this.txtdata.TabIndex = 41;
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(143, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Imię i nazwisko studenta";
            // 
            // btbacksearching
            // 
            this.btbacksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btbacksearching.Image = ((System.Drawing.Image)(resources.GetObject("btbacksearching.Image")));
            this.btbacksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbacksearching.Location = new System.Drawing.Point(248, 393);
            this.btbacksearching.Name = "btbacksearching";
            this.btbacksearching.Size = new System.Drawing.Size(122, 62);
            this.btbacksearching.TabIndex = 39;
            this.btbacksearching.Text = "Anuluj";
            this.btbacksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbacksearching.UseVisualStyleBackColor = true;
            this.btbacksearching.Click += new System.EventHandler(this.btbacksearching_Click);
            // 
            // btoksearching
            // 
            this.btoksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btoksearching.Image = ((System.Drawing.Image)(resources.GetObject("btoksearching.Image")));
            this.btoksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoksearching.Location = new System.Drawing.Point(120, 393);
            this.btoksearching.Name = "btoksearching";
            this.btoksearching.Size = new System.Drawing.Size(122, 62);
            this.btoksearching.TabIndex = 38;
            this.btoksearching.Text = "OK";
            this.btoksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoksearching.UseVisualStyleBackColor = true;
            this.btoksearching.Click += new System.EventHandler(this.btoksearching_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 44);
            this.label1.TabIndex = 37;
            this.label1.Text = "Edycja danych  studenta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btdegrees
            // 
            this.btdegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btdegrees.Image = ((System.Drawing.Image)(resources.GetObject("btdegrees.Image")));
            this.btdegrees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdegrees.Location = new System.Drawing.Point(177, 325);
            this.btdegrees.Name = "btdegrees";
            this.btdegrees.Size = new System.Drawing.Size(135, 62);
            this.btdegrees.TabIndex = 46;
            this.btdegrees.Text = "Oceny";
            this.btdegrees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdegrees.UseVisualStyleBackColor = true;
            this.btdegrees.Click += new System.EventHandler(this.btdegrees_Click);
            // 
            // Detailsediting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 461);
            this.Controls.Add(this.btdegrees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbacksearching);
            this.Controls.Add(this.btoksearching);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Detailsediting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja danych studenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbacksearching;
        private System.Windows.Forms.Button btoksearching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btdegrees;
    }
}