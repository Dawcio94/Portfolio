namespace Studenci
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.label5 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbacksearching = new System.Windows.Forms.Button();
            this.btoksearching = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(167, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Podaj jedno z kryteriów";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdata.Location = new System.Drawing.Point(203, 282);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 29);
            this.txtdata.TabIndex = 40;
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(114, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Podaj imię i nazwisko studenta";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtid.Location = new System.Drawing.Point(203, 223);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 29);
            this.txtid.TabIndex = 38;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(114, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Podaj numer indeksu studenta";
            // 
            // btbacksearching
            // 
            this.btbacksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btbacksearching.Image = ((System.Drawing.Image)(resources.GetObject("btbacksearching.Image")));
            this.btbacksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbacksearching.Location = new System.Drawing.Point(257, 317);
            this.btbacksearching.Name = "btbacksearching";
            this.btbacksearching.Size = new System.Drawing.Size(122, 62);
            this.btbacksearching.TabIndex = 36;
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
            this.btoksearching.Location = new System.Drawing.Point(129, 317);
            this.btoksearching.Name = "btoksearching";
            this.btoksearching.Size = new System.Drawing.Size(122, 62);
            this.btoksearching.TabIndex = 35;
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
            this.label1.TabIndex = 34;
            this.label1.Text = "Edycja danych  studenta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbacksearching);
            this.Controls.Add(this.btoksearching);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Editing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja danych studenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbacksearching;
        private System.Windows.Forms.Button btoksearching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}