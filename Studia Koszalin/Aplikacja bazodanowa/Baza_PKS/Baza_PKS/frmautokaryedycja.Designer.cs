namespace Baza_PKS
{
    partial class frmautokaryedycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmautokaryedycja));
            this.btaneditautokar = new System.Windows.Forms.Button();
            this.btokeditautokar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.tbnrrejst = new System.Windows.Forms.TextBox();
            this.tbmarka = new System.Windows.Forms.TextBox();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.tbmiejsca = new System.Windows.Forms.TextBox();
            this.lbidkursu = new System.Windows.Forms.Label();
            this.tbidkursu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btaneditautokar
            // 
            this.btaneditautokar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btaneditautokar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btaneditautokar.Image = ((System.Drawing.Image)(resources.GetObject("btaneditautokar.Image")));
            this.btaneditautokar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaneditautokar.Location = new System.Drawing.Point(227, 238);
            this.btaneditautokar.Name = "btaneditautokar";
            this.btaneditautokar.Size = new System.Drawing.Size(159, 50);
            this.btaneditautokar.TabIndex = 26;
            this.btaneditautokar.Text = "Anuluj";
            this.btaneditautokar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaneditautokar.UseVisualStyleBackColor = true;
            this.btaneditautokar.Click += new System.EventHandler(this.btaneditautokar_Click);
            // 
            // btokeditautokar
            // 
            this.btokeditautokar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokeditautokar.Image = ((System.Drawing.Image)(resources.GetObject("btokeditautokar.Image")));
            this.btokeditautokar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokeditautokar.Location = new System.Drawing.Point(62, 238);
            this.btokeditautokar.Name = "btokeditautokar";
            this.btokeditautokar.Size = new System.Drawing.Size(159, 50);
            this.btokeditautokar.TabIndex = 25;
            this.btokeditautokar.Text = "OK";
            this.btokeditautokar.UseVisualStyleBackColor = true;
            this.btokeditautokar.Click += new System.EventHandler(this.btokeditautokar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(114, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numer rejestracyjny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(114, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(115, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(114, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Liczba miejsc:";
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 31;
            this.pblogo.TabStop = false;
            // 
            // tbnrrejst
            // 
            this.tbnrrejst.Location = new System.Drawing.Point(271, 94);
            this.tbnrrejst.Name = "tbnrrejst";
            this.tbnrrejst.Size = new System.Drawing.Size(100, 20);
            this.tbnrrejst.TabIndex = 32;
            // 
            // tbmarka
            // 
            this.tbmarka.Location = new System.Drawing.Point(177, 118);
            this.tbmarka.Name = "tbmarka";
            this.tbmarka.Size = new System.Drawing.Size(194, 20);
            this.tbmarka.TabIndex = 33;
            // 
            // tbmodel
            // 
            this.tbmodel.Location = new System.Drawing.Point(177, 140);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(194, 20);
            this.tbmodel.TabIndex = 34;
            // 
            // tbmiejsca
            // 
            this.tbmiejsca.Location = new System.Drawing.Point(227, 163);
            this.tbmiejsca.Name = "tbmiejsca";
            this.tbmiejsca.Size = new System.Drawing.Size(144, 20);
            this.tbmiejsca.TabIndex = 35;
            // 
            // lbidkursu
            // 
            this.lbidkursu.AutoSize = true;
            this.lbidkursu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbidkursu.Location = new System.Drawing.Point(115, 185);
            this.lbidkursu.Name = "lbidkursu";
            this.lbidkursu.Size = new System.Drawing.Size(140, 20);
            this.lbidkursu.TabIndex = 36;
            this.lbidkursu.Text = "Oznaczenie kursu:";
            // 
            // tbidkursu
            // 
            this.tbidkursu.Location = new System.Drawing.Point(261, 185);
            this.tbidkursu.Name = "tbidkursu";
            this.tbidkursu.Size = new System.Drawing.Size(110, 20);
            this.tbidkursu.TabIndex = 37;
            // 
            // frmautokaryedycja
            // 
            this.AcceptButton = this.btokeditautokar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btaneditautokar;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.tbidkursu);
            this.Controls.Add(this.lbidkursu);
            this.Controls.Add(this.tbmiejsca);
            this.Controls.Add(this.tbmodel);
            this.Controls.Add(this.tbmarka);
            this.Controls.Add(this.tbnrrejst);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btaneditautokar);
            this.Controls.Add(this.btokeditautokar);
            this.Name = "frmautokaryedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autokar";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btaneditautokar;
        private System.Windows.Forms.Button btokeditautokar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox tbnrrejst;
        private System.Windows.Forms.TextBox tbmarka;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.TextBox tbmiejsca;
        private System.Windows.Forms.Label lbidkursu;
        private System.Windows.Forms.TextBox tbidkursu;
    }
}