namespace Baza_PKS
{
    partial class frmPasazer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasazer));
            this.cbprzystanekpocz = new System.Windows.Forms.ComboBox();
            this.bspoczatek = new System.Windows.Forms.BindingSource(this.components);
            this.cbprzystanekkon = new System.Windows.Forms.ComboBox();
            this.bskoniec = new System.Windows.Forms.BindingSource(this.components);
            this.tbgodzina = new System.Windows.Forms.TextBox();
            this.btwyszukaj = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.bskurs = new System.Windows.Forms.BindingSource(this.components);
            this.lbprzystanekpoczatkowy = new System.Windows.Forms.Label();
            this.lbz = new System.Windows.Forms.Label();
            this.lbdo = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.lbgodzina = new System.Windows.Forms.Label();
            this.lbprzystanekkoniec = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oznaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.dtpdatapasazer = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roznicaczasuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miejscowości = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsprzebieg = new System.Windows.Forms.BindingSource(this.components);
            this.bsmiej = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bspoczatek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskoniec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprzebieg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiej)).BeginInit();
            this.SuspendLayout();
            // 
            // cbprzystanekpocz
            // 
            this.cbprzystanekpocz.BackColor = System.Drawing.Color.White;
            this.cbprzystanekpocz.DataSource = this.bspoczatek;
            this.cbprzystanekpocz.DisplayMember = "Nazwa_miejscowosci";
            this.cbprzystanekpocz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprzystanekpocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbprzystanekpocz.FormattingEnabled = true;
            this.cbprzystanekpocz.Location = new System.Drawing.Point(40, 162);
            this.cbprzystanekpocz.Name = "cbprzystanekpocz";
            this.cbprzystanekpocz.Size = new System.Drawing.Size(257, 28);
            this.cbprzystanekpocz.TabIndex = 2;
            this.cbprzystanekpocz.ValueMember = "Id_miejscowosci";
            // 
            // bspoczatek
            // 
            this.bspoczatek.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // cbprzystanekkon
            // 
            this.cbprzystanekkon.BackColor = System.Drawing.Color.White;
            this.cbprzystanekkon.DataSource = this.bskoniec;
            this.cbprzystanekkon.DisplayMember = "Nazwa_miejscowosci";
            this.cbprzystanekkon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprzystanekkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbprzystanekkon.FormattingEnabled = true;
            this.cbprzystanekkon.Location = new System.Drawing.Point(51, 233);
            this.cbprzystanekkon.Name = "cbprzystanekkon";
            this.cbprzystanekkon.Size = new System.Drawing.Size(246, 28);
            this.cbprzystanekkon.TabIndex = 5;
            this.cbprzystanekkon.ValueMember = "Id_miejscowosci";
            // 
            // bskoniec
            // 
            this.bskoniec.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // tbgodzina
            // 
            this.tbgodzina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbgodzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbgodzina.Location = new System.Drawing.Point(130, 324);
            this.tbgodzina.Name = "tbgodzina";
            this.tbgodzina.Size = new System.Drawing.Size(167, 26);
            this.tbgodzina.TabIndex = 9;
            // 
            // btwyszukaj
            // 
            this.btwyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btwyszukaj.Image = ((System.Drawing.Image)(resources.GetObject("btwyszukaj.Image")));
            this.btwyszukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btwyszukaj.Location = new System.Drawing.Point(66, 377);
            this.btwyszukaj.Name = "btwyszukaj";
            this.btwyszukaj.Size = new System.Drawing.Size(183, 84);
            this.btwyszukaj.TabIndex = 10;
            this.btwyszukaj.Text = "Wyszukaj";
            this.btwyszukaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btwyszukaj.UseVisualStyleBackColor = true;
            this.btwyszukaj.Click += new System.EventHandler(this.btwyszukaj_Click);
            // 
            // btlog
            // 
            this.btlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btlog.Image = ((System.Drawing.Image)(resources.GetObject("btlog.Image")));
            this.btlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlog.Location = new System.Drawing.Point(773, 12);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(159, 50);
            this.btlog.TabIndex = 11;
            this.btlog.Text = "Zaloguj";
            this.btlog.UseVisualStyleBackColor = true;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // bskurs
            // 
            this.bskurs.DataSource = typeof(Baza_PKS.Kurs);
            // 
            // lbprzystanekpoczatkowy
            // 
            this.lbprzystanekpoczatkowy.AutoSize = true;
            this.lbprzystanekpoczatkowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbprzystanekpoczatkowy.Location = new System.Drawing.Point(11, 134);
            this.lbprzystanekpoczatkowy.Name = "lbprzystanekpoczatkowy";
            this.lbprzystanekpoczatkowy.Size = new System.Drawing.Size(174, 20);
            this.lbprzystanekpoczatkowy.TabIndex = 13;
            this.lbprzystanekpoczatkowy.Text = "Przystanek początkowy";
            // 
            // lbz
            // 
            this.lbz.AutoSize = true;
            this.lbz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbz.Location = new System.Drawing.Point(11, 165);
            this.lbz.Name = "lbz";
            this.lbz.Size = new System.Drawing.Size(23, 20);
            this.lbz.TabIndex = 14;
            this.lbz.Text = "Z:";
            // 
            // lbdo
            // 
            this.lbdo.AutoSize = true;
            this.lbdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdo.Location = new System.Drawing.Point(11, 233);
            this.lbdo.Name = "lbdo";
            this.lbdo.Size = new System.Drawing.Size(34, 20);
            this.lbdo.TabIndex = 15;
            this.lbdo.Text = "Do:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdata.Location = new System.Drawing.Point(11, 290);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(89, 20);
            this.lbdata.TabIndex = 16;
            this.lbdata.Text = "Podaj datę:";
            // 
            // lbgodzina
            // 
            this.lbgodzina.AutoSize = true;
            this.lbgodzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbgodzina.Location = new System.Drawing.Point(11, 324);
            this.lbgodzina.Name = "lbgodzina";
            this.lbgodzina.Size = new System.Drawing.Size(113, 20);
            this.lbgodzina.TabIndex = 17;
            this.lbgodzina.Text = "Podaj godzinę:";
            // 
            // lbprzystanekkoniec
            // 
            this.lbprzystanekkoniec.AutoSize = true;
            this.lbprzystanekkoniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbprzystanekkoniec.Location = new System.Drawing.Point(11, 210);
            this.lbprzystanekkoniec.Name = "lbprzystanekkoniec";
            this.lbprzystanekkoniec.Size = new System.Drawing.Size(152, 20);
            this.lbprzystanekkoniec.TabIndex = 18;
            this.lbprzystanekkoniec.Text = "Przystanek końcowy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oznaczenieDataGridViewTextBoxColumn,
            this.datakursuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bskurs;
            this.dataGridView1.Location = new System.Drawing.Point(314, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 327);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 20;
            this.pblogo.TabStop = false;
            // 
            // dtpdatapasazer
            // 
            this.dtpdatapasazer.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpdatapasazer.Location = new System.Drawing.Point(97, 290);
            this.dtpdatapasazer.Name = "dtpdatapasazer";
            this.dtpdatapasazer.Size = new System.Drawing.Size(200, 20);
            this.dtpdatapasazer.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roznicaczasuDataGridViewTextBoxColumn,
            this.Miejscowości});
            this.dataGridView2.DataSource = this.bsprzebieg;
            this.dataGridView2.Location = new System.Drawing.Point(564, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(244, 327);
            this.dataGridView2.TabIndex = 22;
            // 
            // roznicaczasuDataGridViewTextBoxColumn
            // 
            this.roznicaczasuDataGridViewTextBoxColumn.DataPropertyName = "Roznica_czasu";
            this.roznicaczasuDataGridViewTextBoxColumn.HeaderText = "Godzina_odjazdu";
            this.roznicaczasuDataGridViewTextBoxColumn.Name = "roznicaczasuDataGridViewTextBoxColumn";
            this.roznicaczasuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Miejscowości
            // 
            this.Miejscowości.DataPropertyName = "Miejscowości";
            this.Miejscowości.HeaderText = "Miejscowości";
            this.Miejscowości.Name = "Miejscowości";
            this.Miejscowości.ReadOnly = true;
            // 
            // bsprzebieg
            // 
            this.bsprzebieg.DataSource = typeof(Baza_PKS.Przebieg);
            // 
            // bsmiej
            // 
            this.bsmiej.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // frmPasazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpdatapasazer);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbprzystanekkoniec);
            this.Controls.Add(this.lbgodzina);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lbdo);
            this.Controls.Add(this.lbz);
            this.Controls.Add(this.lbprzystanekpoczatkowy);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.btwyszukaj);
            this.Controls.Add(this.tbgodzina);
            this.Controls.Add(this.cbprzystanekkon);
            this.Controls.Add(this.cbprzystanekpocz);
            this.Name = "frmPasazer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyszukiwarka połączeń PKS";
            this.Load += new System.EventHandler(this.frmPasazer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bspoczatek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskoniec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprzebieg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbprzystanekpocz;
        private System.Windows.Forms.ComboBox cbprzystanekkon;
        private System.Windows.Forms.TextBox tbgodzina;
        private System.Windows.Forms.Button btwyszukaj;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Label lbprzystanekpoczatkowy;
        private System.Windows.Forms.Label lbz;
        private System.Windows.Forms.Label lbdo;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label lbgodzina;
        private System.Windows.Forms.Label lbprzystanekkoniec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.BindingSource bspoczatek;
        private System.Windows.Forms.BindingSource bskoniec;
        private System.Windows.Forms.DateTimePicker dtpdatapasazer;
        private System.Windows.Forms.BindingSource bskurs;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsprzebieg;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsmiej;
        private System.Windows.Forms.DataGridViewTextBoxColumn roznicaczasuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejscowości;
    }
}