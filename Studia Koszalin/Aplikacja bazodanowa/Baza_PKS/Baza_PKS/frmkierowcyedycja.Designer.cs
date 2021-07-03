namespace Baza_PKS
{
    partial class frmkierowcyedycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkierowcyedycja));
            this.label1 = new System.Windows.Forms.Label();
            this.tbimienazwisko = new System.Windows.Forms.TextBox();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btokeditkierowcy = new System.Windows.Forms.Button();
            this.btaneditkierowcy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbidkursu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie i nazwisko:";
            // 
            // tbimienazwisko
            // 
            this.tbimienazwisko.Location = new System.Drawing.Point(223, 115);
            this.tbimienazwisko.Name = "tbimienazwisko";
            this.tbimienazwisko.Size = new System.Drawing.Size(156, 20);
            this.tbimienazwisko.TabIndex = 1;
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 22;
            this.pblogo.TabStop = false;
            // 
            // btokeditkierowcy
            // 
            this.btokeditkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokeditkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btokeditkierowcy.Image")));
            this.btokeditkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokeditkierowcy.Location = new System.Drawing.Point(58, 202);
            this.btokeditkierowcy.Name = "btokeditkierowcy";
            this.btokeditkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btokeditkierowcy.TabIndex = 23;
            this.btokeditkierowcy.Text = "OK";
            this.btokeditkierowcy.UseVisualStyleBackColor = true;
            this.btokeditkierowcy.Click += new System.EventHandler(this.btokeditkierowcy_Click);
            // 
            // btaneditkierowcy
            // 
            this.btaneditkierowcy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btaneditkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btaneditkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btaneditkierowcy.Image")));
            this.btaneditkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaneditkierowcy.Location = new System.Drawing.Point(223, 202);
            this.btaneditkierowcy.Name = "btaneditkierowcy";
            this.btaneditkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btaneditkierowcy.TabIndex = 24;
            this.btaneditkierowcy.Text = "Anuluj";
            this.btaneditkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaneditkierowcy.UseVisualStyleBackColor = true;
            this.btaneditkierowcy.Click += new System.EventHandler(this.btaneditkierowcy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(98, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Oznaczenie kursu:";
            // 
            // tbidkursu
            // 
            this.tbidkursu.Location = new System.Drawing.Point(244, 136);
            this.tbidkursu.Name = "tbidkursu";
            this.tbidkursu.Size = new System.Drawing.Size(135, 20);
            this.tbidkursu.TabIndex = 26;
            // 
            // frmkierowcyedycja
            // 
            this.AcceptButton = this.btokeditkierowcy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btaneditkierowcy;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.tbidkursu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btaneditkierowcy);
            this.Controls.Add(this.btokeditkierowcy);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.tbimienazwisko);
            this.Controls.Add(this.label1);
            this.Name = "frmkierowcyedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kierowcy";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbimienazwisko;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btokeditkierowcy;
        private System.Windows.Forms.Button btaneditkierowcy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbidkursu;
    }
}