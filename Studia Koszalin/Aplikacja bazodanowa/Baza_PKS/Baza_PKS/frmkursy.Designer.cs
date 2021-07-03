namespace Baza_PKS
{
    partial class frmkursy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkursy));
            this.lbdanekursy = new System.Windows.Forms.Label();
            this.dgkursy = new System.Windows.Forms.DataGridView();
            this.oznaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćpasażerówDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinarozpoczeciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bskursy = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbilosc = new System.Windows.Forms.TextBox();
            this.lbkurs = new System.Windows.Forms.Label();
            this.tboznaczenie = new System.Windows.Forms.TextBox();
            this.btsrednia = new System.Windows.Forms.Button();
            this.btrtyg = new System.Windows.Forms.Button();
            this.btusunkursy = new System.Windows.Forms.Button();
            this.btedytujkursy = new System.Windows.Forms.Button();
            this.btdodajkursy = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btcbkursy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgkursy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskursy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdanekursy
            // 
            this.lbdanekursy.AutoSize = true;
            this.lbdanekursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdanekursy.Location = new System.Drawing.Point(297, 135);
            this.lbdanekursy.Name = "lbdanekursy";
            this.lbdanekursy.Size = new System.Drawing.Size(91, 20);
            this.lbdanekursy.TabIndex = 27;
            this.lbdanekursy.Text = "Dane kursu";
            // 
            // dgkursy
            // 
            this.dgkursy.AllowUserToAddRows = false;
            this.dgkursy.AllowUserToDeleteRows = false;
            this.dgkursy.AutoGenerateColumns = false;
            this.dgkursy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkursy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oznaczenieDataGridViewTextBoxColumn,
            this.datakursuDataGridViewTextBoxColumn,
            this.ilośćpasażerówDataGridViewTextBoxColumn,
            this.godzinarozpoczeciaDataGridViewTextBoxColumn,
            this.Trasa});
            this.dgkursy.DataSource = this.bskursy;
            this.dgkursy.Location = new System.Drawing.Point(301, 158);
            this.dgkursy.Name = "dgkursy";
            this.dgkursy.ReadOnly = true;
            this.dgkursy.Size = new System.Drawing.Size(545, 150);
            this.dgkursy.TabIndex = 28;
            // 
            // oznaczenieDataGridViewTextBoxColumn
            // 
            this.oznaczenieDataGridViewTextBoxColumn.DataPropertyName = "Oznaczenie";
            this.oznaczenieDataGridViewTextBoxColumn.HeaderText = "Oznaczenie";
            this.oznaczenieDataGridViewTextBoxColumn.Name = "oznaczenieDataGridViewTextBoxColumn";
            this.oznaczenieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datakursuDataGridViewTextBoxColumn
            // 
            this.datakursuDataGridViewTextBoxColumn.DataPropertyName = "Data_kursu";
            this.datakursuDataGridViewTextBoxColumn.HeaderText = "Data_kursu";
            this.datakursuDataGridViewTextBoxColumn.Name = "datakursuDataGridViewTextBoxColumn";
            this.datakursuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilośćpasażerówDataGridViewTextBoxColumn
            // 
            this.ilośćpasażerówDataGridViewTextBoxColumn.DataPropertyName = "Ilość_pasażerów";
            this.ilośćpasażerówDataGridViewTextBoxColumn.HeaderText = "Ilość_pasażerów";
            this.ilośćpasażerówDataGridViewTextBoxColumn.Name = "ilośćpasażerówDataGridViewTextBoxColumn";
            this.ilośćpasażerówDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godzinarozpoczeciaDataGridViewTextBoxColumn
            // 
            this.godzinarozpoczeciaDataGridViewTextBoxColumn.DataPropertyName = "Godzina_rozpoczecia";
            this.godzinarozpoczeciaDataGridViewTextBoxColumn.HeaderText = "Godzina_rozpoczecia";
            this.godzinarozpoczeciaDataGridViewTextBoxColumn.Name = "godzinarozpoczeciaDataGridViewTextBoxColumn";
            this.godzinarozpoczeciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Trasa
            // 
            this.Trasa.DataPropertyName = "Trasa";
            this.Trasa.HeaderText = "Trasa";
            this.Trasa.Name = "Trasa";
            this.Trasa.ReadOnly = true;
            // 
            // bskursy
            // 
            this.bskursy.DataSource = typeof(Baza_PKS.Kurs);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(297, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ilość pasażerów:";
            // 
            // tbilosc
            // 
            this.tbilosc.Location = new System.Drawing.Point(430, 441);
            this.tbilosc.Name = "tbilosc";
            this.tbilosc.Size = new System.Drawing.Size(100, 20);
            this.tbilosc.TabIndex = 32;
            // 
            // lbkurs
            // 
            this.lbkurs.AutoSize = true;
            this.lbkurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbkurs.Location = new System.Drawing.Point(298, 325);
            this.lbkurs.Name = "lbkurs";
            this.lbkurs.Size = new System.Drawing.Size(140, 20);
            this.lbkurs.TabIndex = 33;
            this.lbkurs.Text = "Oznaczenie kursu:";
            // 
            // tboznaczenie
            // 
            this.tboznaczenie.Location = new System.Drawing.Point(302, 349);
            this.tboznaczenie.Name = "tboznaczenie";
            this.tboznaczenie.Size = new System.Drawing.Size(132, 20);
            this.tboznaczenie.TabIndex = 34;
            // 
            // btsrednia
            // 
            this.btsrednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btsrednia.Image = ((System.Drawing.Image)(resources.GetObject("btsrednia.Image")));
            this.btsrednia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsrednia.Location = new System.Drawing.Point(466, 375);
            this.btsrednia.Name = "btsrednia";
            this.btsrednia.Size = new System.Drawing.Size(159, 50);
            this.btsrednia.TabIndex = 30;
            this.btsrednia.Text = "Średnia";
            this.btsrednia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsrednia.UseVisualStyleBackColor = true;
            this.btsrednia.Click += new System.EventHandler(this.btsrednia_Click);
            // 
            // btrtyg
            // 
            this.btrtyg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btrtyg.Image = ((System.Drawing.Image)(resources.GetObject("btrtyg.Image")));
            this.btrtyg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrtyg.Location = new System.Drawing.Point(301, 375);
            this.btrtyg.Name = "btrtyg";
            this.btrtyg.Size = new System.Drawing.Size(159, 50);
            this.btrtyg.TabIndex = 29;
            this.btrtyg.Text = "Tygodniowy";
            this.btrtyg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btrtyg.UseVisualStyleBackColor = true;
            this.btrtyg.Click += new System.EventHandler(this.btrtyg_Click);
            // 
            // btusunkursy
            // 
            this.btusunkursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusunkursy.Image = ((System.Drawing.Image)(resources.GetObject("btusunkursy.Image")));
            this.btusunkursy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusunkursy.Location = new System.Drawing.Point(61, 303);
            this.btusunkursy.Name = "btusunkursy";
            this.btusunkursy.Size = new System.Drawing.Size(159, 50);
            this.btusunkursy.TabIndex = 24;
            this.btusunkursy.Text = "Usuń";
            this.btusunkursy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusunkursy.UseVisualStyleBackColor = true;
            this.btusunkursy.Click += new System.EventHandler(this.btusunkursy_Click);
            // 
            // btedytujkursy
            // 
            this.btedytujkursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujkursy.Image = ((System.Drawing.Image)(resources.GetObject("btedytujkursy.Image")));
            this.btedytujkursy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujkursy.Location = new System.Drawing.Point(61, 247);
            this.btedytujkursy.Name = "btedytujkursy";
            this.btedytujkursy.Size = new System.Drawing.Size(159, 50);
            this.btedytujkursy.TabIndex = 23;
            this.btedytujkursy.Text = "Edytuj";
            this.btedytujkursy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujkursy.UseVisualStyleBackColor = true;
            this.btedytujkursy.Click += new System.EventHandler(this.btedytujkursy_Click);
            // 
            // btdodajkursy
            // 
            this.btdodajkursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajkursy.Image = ((System.Drawing.Image)(resources.GetObject("btdodajkursy.Image")));
            this.btdodajkursy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajkursy.Location = new System.Drawing.Point(61, 191);
            this.btdodajkursy.Name = "btdodajkursy";
            this.btdodajkursy.Size = new System.Drawing.Size(159, 50);
            this.btdodajkursy.TabIndex = 22;
            this.btdodajkursy.Text = "Dodaj";
            this.btdodajkursy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajkursy.UseVisualStyleBackColor = true;
            this.btdodajkursy.Click += new System.EventHandler(this.btdodajkursy_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 21;
            this.pblogo.TabStop = false;
            // 
            // btcbkursy
            // 
            this.btcbkursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbkursy.Image = ((System.Drawing.Image)(resources.GetObject("btcbkursy.Image")));
            this.btcbkursy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbkursy.Location = new System.Drawing.Point(773, 439);
            this.btcbkursy.Name = "btcbkursy";
            this.btcbkursy.Size = new System.Drawing.Size(159, 50);
            this.btcbkursy.TabIndex = 0;
            this.btcbkursy.Text = "Powrót";
            this.btcbkursy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbkursy.UseVisualStyleBackColor = true;
            this.btcbkursy.Click += new System.EventHandler(this.btcbkursy_Click);
            // 
            // frmkursy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tboznaczenie);
            this.Controls.Add(this.lbkurs);
            this.Controls.Add(this.tbilosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsrednia);
            this.Controls.Add(this.btrtyg);
            this.Controls.Add(this.dgkursy);
            this.Controls.Add(this.lbdanekursy);
            this.Controls.Add(this.btusunkursy);
            this.Controls.Add(this.btedytujkursy);
            this.Controls.Add(this.btdodajkursy);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btcbkursy);
            this.Name = "frmkursy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursy";
            ((System.ComponentModel.ISupportInitialize)(this.dgkursy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskursy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbkursy;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btusunkursy;
        private System.Windows.Forms.Button btedytujkursy;
        private System.Windows.Forms.Button btdodajkursy;
        private System.Windows.Forms.Label lbdanekursy;
        private System.Windows.Forms.DataGridView dgkursy;
        private System.Windows.Forms.Button btrtyg;
        private System.Windows.Forms.Button btsrednia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbilosc;
        private System.Windows.Forms.BindingSource bskursy;
        private System.Windows.Forms.Label lbkurs;
        private System.Windows.Forms.TextBox tboznaczenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćpasażerówDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinarozpoczeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trasa;
    }
}