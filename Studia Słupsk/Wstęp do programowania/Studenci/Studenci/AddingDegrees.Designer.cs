namespace Studenci
{
    partial class AddingDegrees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingDegrees));
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btbacksearching = new System.Windows.Forms.Button();
            this.btoksearching = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdegree = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsubject.Location = new System.Drawing.Point(113, 183);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(250, 29);
            this.txtsubject.TabIndex = 49;
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(168, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Podaj przedmiot";
            // 
            // btbacksearching
            // 
            this.btbacksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btbacksearching.Image = ((System.Drawing.Image)(resources.GetObject("btbacksearching.Image")));
            this.btbacksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbacksearching.Location = new System.Drawing.Point(236, 283);
            this.btbacksearching.Name = "btbacksearching";
            this.btbacksearching.Size = new System.Drawing.Size(137, 62);
            this.btbacksearching.TabIndex = 41;
            this.btbacksearching.Text = "Powrót";
            this.btbacksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbacksearching.UseVisualStyleBackColor = true;
            this.btbacksearching.Click += new System.EventHandler(this.btbacksearching_Click);
            // 
            // btoksearching
            // 
            this.btoksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btoksearching.Image = ((System.Drawing.Image)(resources.GetObject("btoksearching.Image")));
            this.btoksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoksearching.Location = new System.Drawing.Point(93, 283);
            this.btoksearching.Name = "btoksearching";
            this.btoksearching.Size = new System.Drawing.Size(137, 62);
            this.btoksearching.TabIndex = 40;
            this.btoksearching.Text = "Dodaj";
            this.btoksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoksearching.UseVisualStyleBackColor = true;
            this.btoksearching.Click += new System.EventHandler(this.btoksearching_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(85, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 44);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dodawanie  ocen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(140, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Podaj ocene studenta";
            // 
            // txtdegree
            // 
            this.txtdegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdegree.Location = new System.Drawing.Point(189, 242);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.Size = new System.Drawing.Size(100, 29);
            this.txtdegree.TabIndex = 51;
            this.txtdegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddingDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 357);
            this.Controls.Add(this.txtdegree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btbacksearching);
            this.Controls.Add(this.btoksearching);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddingDegrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie ocen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btbacksearching;
        private System.Windows.Forms.Button btoksearching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdegree;
    }
}