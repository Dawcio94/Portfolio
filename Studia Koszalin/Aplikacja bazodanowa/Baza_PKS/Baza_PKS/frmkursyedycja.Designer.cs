namespace Baza_PKS
{
    partial class frmkursyedycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkursyedycja));
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboznaczniekursu = new System.Windows.Forms.TextBox();
            this.tbiloscpasazerow = new System.Windows.Forms.TextBox();
            this.tbgodzrozp = new System.Windows.Forms.TextBox();
            this.tbidtrasy = new System.Windows.Forms.TextBox();
            this.btaneditkurs = new System.Windows.Forms.Button();
            this.btokeditkurs = new System.Windows.Forms.Button();
            this.dtpkurs = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 32;
            this.pblogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(100, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Oznaczenie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(100, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Data kursu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(100, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Godzina rozpoczęcia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(100, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Oznaczenie trasy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(100, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ilość pasażerów:";
            // 
            // tboznaczniekursu
            // 
            this.tboznaczniekursu.Location = new System.Drawing.Point(203, 103);
            this.tboznaczniekursu.Name = "tboznaczniekursu";
            this.tboznaczniekursu.Size = new System.Drawing.Size(194, 20);
            this.tboznaczniekursu.TabIndex = 38;
            // 
            // tbiloscpasazerow
            // 
            this.tbiloscpasazerow.Location = new System.Drawing.Point(233, 153);
            this.tbiloscpasazerow.Name = "tbiloscpasazerow";
            this.tbiloscpasazerow.Size = new System.Drawing.Size(164, 20);
            this.tbiloscpasazerow.TabIndex = 39;
            // 
            // tbgodzrozp
            // 
            this.tbgodzrozp.Location = new System.Drawing.Point(268, 176);
            this.tbgodzrozp.Name = "tbgodzrozp";
            this.tbgodzrozp.Size = new System.Drawing.Size(129, 20);
            this.tbgodzrozp.TabIndex = 40;
            // 
            // tbidtrasy
            // 
            this.tbidtrasy.Location = new System.Drawing.Point(241, 198);
            this.tbidtrasy.Name = "tbidtrasy";
            this.tbidtrasy.Size = new System.Drawing.Size(156, 20);
            this.tbidtrasy.TabIndex = 41;
            // 
            // btaneditkurs
            // 
            this.btaneditkurs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btaneditkurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btaneditkurs.Image = ((System.Drawing.Image)(resources.GetObject("btaneditkurs.Image")));
            this.btaneditkurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaneditkurs.Location = new System.Drawing.Point(229, 239);
            this.btaneditkurs.Name = "btaneditkurs";
            this.btaneditkurs.Size = new System.Drawing.Size(159, 50);
            this.btaneditkurs.TabIndex = 44;
            this.btaneditkurs.Text = "Anuluj";
            this.btaneditkurs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaneditkurs.UseVisualStyleBackColor = true;
            this.btaneditkurs.Click += new System.EventHandler(this.btaneditkurs_Click);
            // 
            // btokeditkurs
            // 
            this.btokeditkurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokeditkurs.Image = ((System.Drawing.Image)(resources.GetObject("btokeditkurs.Image")));
            this.btokeditkurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokeditkurs.Location = new System.Drawing.Point(64, 239);
            this.btokeditkurs.Name = "btokeditkurs";
            this.btokeditkurs.Size = new System.Drawing.Size(159, 50);
            this.btokeditkurs.TabIndex = 43;
            this.btokeditkurs.Text = "OK";
            this.btokeditkurs.UseVisualStyleBackColor = true;
            this.btokeditkurs.Click += new System.EventHandler(this.btokeditkurs_Click);
            // 
            // dtpkurs
            // 
            this.dtpkurs.Location = new System.Drawing.Point(197, 130);
            this.dtpkurs.Name = "dtpkurs";
            this.dtpkurs.Size = new System.Drawing.Size(200, 20);
            this.dtpkurs.TabIndex = 45;
            // 
            // frmkursyedycja
            // 
            this.AcceptButton = this.btokeditkurs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btaneditkurs;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.dtpkurs);
            this.Controls.Add(this.btaneditkurs);
            this.Controls.Add(this.btokeditkurs);
            this.Controls.Add(this.tbidtrasy);
            this.Controls.Add(this.tbgodzrozp);
            this.Controls.Add(this.tbiloscpasazerow);
            this.Controls.Add(this.tboznaczniekursu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pblogo);
            this.Name = "frmkursyedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursy";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboznaczniekursu;
        private System.Windows.Forms.TextBox tbiloscpasazerow;
        private System.Windows.Forms.TextBox tbgodzrozp;
        private System.Windows.Forms.TextBox tbidtrasy;
        private System.Windows.Forms.Button btaneditkurs;
        private System.Windows.Forms.Button btokeditkurs;
        private System.Windows.Forms.DateTimePicker dtpkurs;
    }
}