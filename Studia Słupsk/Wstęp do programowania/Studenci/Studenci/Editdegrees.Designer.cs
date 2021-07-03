namespace Studenci
{
    partial class Editdegrees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editdegrees));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.txtdegree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btbacksearching = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 44);
            this.label1.TabIndex = 39;
            this.label1.Text = "Edycja ocen studenta";
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
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(224, 314);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(169, 66);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "Usuń";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(49, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 66);
            this.Add.TabIndex = 40;
            this.Add.Text = "Dodaj";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtdegree
            // 
            this.txtdegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtdegree.Location = new System.Drawing.Point(176, 267);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.Size = new System.Drawing.Size(100, 29);
            this.txtdegree.TabIndex = 56;
            this.txtdegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(127, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Podaj ocene studenta";
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsubject.Location = new System.Drawing.Point(100, 208);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(250, 29);
            this.txtsubject.TabIndex = 54;
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(155, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Podaj przedmiot";
            // 
            // btbacksearching
            // 
            this.btbacksearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btbacksearching.Image = ((System.Drawing.Image)(resources.GetObject("btbacksearching.Image")));
            this.btbacksearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbacksearching.Location = new System.Drawing.Point(159, 386);
            this.btbacksearching.Name = "btbacksearching";
            this.btbacksearching.Size = new System.Drawing.Size(137, 62);
            this.btbacksearching.TabIndex = 57;
            this.btbacksearching.Text = "Powrót";
            this.btbacksearching.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbacksearching.UseVisualStyleBackColor = true;
            this.btbacksearching.Click += new System.EventHandler(this.btbacksearching_Click);
            // 
            // Editdegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.btbacksearching);
            this.Controls.Add(this.txtdegree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Editdegrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja ocen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtdegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btbacksearching;
    }
}