namespace Baza_PKS
{
    partial class frmtrasyedycja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrasyedycja));
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btanedittrasy = new System.Windows.Forms.Button();
            this.btokedittrasy = new System.Windows.Forms.Button();
            this.lbidmiejscapocz = new System.Windows.Forms.Label();
            this.lbidmiejscakon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboznacztrasy = new System.Windows.Forms.TextBox();
            this.cbmiastopocz = new System.Windows.Forms.ComboBox();
            this.cbmiastokoniec = new System.Windows.Forms.ComboBox();
            this.bsmiastopocz = new System.Windows.Forms.BindingSource(this.components);
            this.bsmiastokon = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastopocz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastokon)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 23;
            this.pblogo.TabStop = false;
            // 
            // btanedittrasy
            // 
            this.btanedittrasy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btanedittrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btanedittrasy.Image = ((System.Drawing.Image)(resources.GetObject("btanedittrasy.Image")));
            this.btanedittrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btanedittrasy.Location = new System.Drawing.Point(227, 215);
            this.btanedittrasy.Name = "btanedittrasy";
            this.btanedittrasy.Size = new System.Drawing.Size(159, 50);
            this.btanedittrasy.TabIndex = 26;
            this.btanedittrasy.Text = "Anuluj";
            this.btanedittrasy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btanedittrasy.UseVisualStyleBackColor = true;
            this.btanedittrasy.Click += new System.EventHandler(this.btanedittrasy_Click);
            // 
            // btokedittrasy
            // 
            this.btokedittrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokedittrasy.Image = ((System.Drawing.Image)(resources.GetObject("btokedittrasy.Image")));
            this.btokedittrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokedittrasy.Location = new System.Drawing.Point(62, 215);
            this.btokedittrasy.Name = "btokedittrasy";
            this.btokedittrasy.Size = new System.Drawing.Size(159, 50);
            this.btokedittrasy.TabIndex = 25;
            this.btokedittrasy.Text = "OK";
            this.btokedittrasy.UseVisualStyleBackColor = true;
            this.btokedittrasy.Click += new System.EventHandler(this.btokedittrasy_Click);
            // 
            // lbidmiejscapocz
            // 
            this.lbidmiejscapocz.AutoSize = true;
            this.lbidmiejscapocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbidmiejscapocz.Location = new System.Drawing.Point(58, 112);
            this.lbidmiejscapocz.Name = "lbidmiejscapocz";
            this.lbidmiejscapocz.Size = new System.Drawing.Size(191, 20);
            this.lbidmiejscapocz.TabIndex = 27;
            this.lbidmiejscapocz.Text = "Miejscowość początkowa:";
            // 
            // lbidmiejscakon
            // 
            this.lbidmiejscakon.AutoSize = true;
            this.lbidmiejscakon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbidmiejscakon.Location = new System.Drawing.Point(58, 138);
            this.lbidmiejscakon.Name = "lbidmiejscakon";
            this.lbidmiejscakon.Size = new System.Drawing.Size(169, 20);
            this.lbidmiejscakon.TabIndex = 28;
            this.lbidmiejscakon.Text = "Miejscowość końcowa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Oznaczenie trasy:";
            // 
            // tboznacztrasy
            // 
            this.tboznacztrasy.Location = new System.Drawing.Point(199, 158);
            this.tboznacztrasy.Name = "tboznacztrasy";
            this.tboznacztrasy.Size = new System.Drawing.Size(187, 20);
            this.tboznacztrasy.TabIndex = 30;
            // 
            // cbmiastopocz
            // 
            this.cbmiastopocz.DataSource = this.bsmiastopocz;
            this.cbmiastopocz.DisplayMember = "Nazwa_miejscowosci";
            this.cbmiastopocz.FormattingEnabled = true;
            this.cbmiastopocz.Location = new System.Drawing.Point(255, 112);
            this.cbmiastopocz.Name = "cbmiastopocz";
            this.cbmiastopocz.Size = new System.Drawing.Size(131, 21);
            this.cbmiastopocz.TabIndex = 31;
            // 
            // cbmiastokoniec
            // 
            this.cbmiastokoniec.DataSource = this.bsmiastokon;
            this.cbmiastokoniec.DisplayMember = "Nazwa_miejscowosci";
            this.cbmiastokoniec.FormattingEnabled = true;
            this.cbmiastokoniec.Location = new System.Drawing.Point(233, 135);
            this.cbmiastokoniec.Name = "cbmiastokoniec";
            this.cbmiastokoniec.Size = new System.Drawing.Size(153, 21);
            this.cbmiastokoniec.TabIndex = 32;
            // 
            // bsmiastopocz
            // 
            this.bsmiastopocz.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // bsmiastokon
            // 
            this.bsmiastokon.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // frmtrasyedycja
            // 
            this.AcceptButton = this.btokedittrasy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btanedittrasy;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.cbmiastokoniec);
            this.Controls.Add(this.cbmiastopocz);
            this.Controls.Add(this.tboznacztrasy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbidmiejscakon);
            this.Controls.Add(this.lbidmiejscapocz);
            this.Controls.Add(this.btanedittrasy);
            this.Controls.Add(this.btokedittrasy);
            this.Controls.Add(this.pblogo);
            this.Name = "frmtrasyedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trasy";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastopocz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastokon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btanedittrasy;
        private System.Windows.Forms.Button btokedittrasy;
        private System.Windows.Forms.Label lbidmiejscapocz;
        private System.Windows.Forms.Label lbidmiejscakon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboznacztrasy;
        private System.Windows.Forms.ComboBox cbmiastopocz;
        private System.Windows.Forms.ComboBox cbmiastokoniec;
        private System.Windows.Forms.BindingSource bsmiastopocz;
        private System.Windows.Forms.BindingSource bsmiastokon;
    }
}