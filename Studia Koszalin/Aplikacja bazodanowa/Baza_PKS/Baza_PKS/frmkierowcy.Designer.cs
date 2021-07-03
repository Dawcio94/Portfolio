namespace Baza_PKS
{
    partial class frmkierowcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkierowcy));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bskierowcy = new System.Windows.Forms.BindingSource(this.components);
            this.lbdanekierowcy = new System.Windows.Forms.Label();
            this.btusunkierowcy = new System.Windows.Forms.Button();
            this.btedytujkierowcy = new System.Windows.Forms.Button();
            this.btdodajkierowcy = new System.Windows.Forms.Button();
            this.btszukajkierowcy = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btcbkierowcy = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.imieNazwiskoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bskierowcywtr = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bskurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowcywtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieNazwiskoDataGridViewTextBoxColumn,
            this.Kurs});
            this.dataGridView1.DataSource = this.bskierowcy;
            this.dataGridView1.Location = new System.Drawing.Point(301, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(246, 139);
            this.dataGridView1.TabIndex = 27;
            // 
            // imieNazwiskoDataGridViewTextBoxColumn
            // 
            this.imieNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.HeaderText = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.Name = "imieNazwiskoDataGridViewTextBoxColumn";
            this.imieNazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // bskierowcy
            // 
            this.bskierowcy.DataSource = typeof(Baza_PKS.Kierowca);
            // 
            // lbdanekierowcy
            // 
            this.lbdanekierowcy.AutoSize = true;
            this.lbdanekierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdanekierowcy.Location = new System.Drawing.Point(297, 135);
            this.lbdanekierowcy.Name = "lbdanekierowcy";
            this.lbdanekierowcy.Size = new System.Drawing.Size(112, 20);
            this.lbdanekierowcy.TabIndex = 26;
            this.lbdanekierowcy.Text = "Dane kierowcy";
            // 
            // btusunkierowcy
            // 
            this.btusunkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusunkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btusunkierowcy.Image")));
            this.btusunkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusunkierowcy.Location = new System.Drawing.Point(61, 303);
            this.btusunkierowcy.Name = "btusunkierowcy";
            this.btusunkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btusunkierowcy.TabIndex = 25;
            this.btusunkierowcy.Text = "Usuń";
            this.btusunkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusunkierowcy.UseVisualStyleBackColor = true;
            this.btusunkierowcy.Click += new System.EventHandler(this.btusunkierowcy_Click);
            // 
            // btedytujkierowcy
            // 
            this.btedytujkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btedytujkierowcy.Image")));
            this.btedytujkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujkierowcy.Location = new System.Drawing.Point(61, 247);
            this.btedytujkierowcy.Name = "btedytujkierowcy";
            this.btedytujkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btedytujkierowcy.TabIndex = 24;
            this.btedytujkierowcy.Text = "Edytuj";
            this.btedytujkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujkierowcy.UseVisualStyleBackColor = true;
            this.btedytujkierowcy.Click += new System.EventHandler(this.btedytujkierowcy_Click);
            // 
            // btdodajkierowcy
            // 
            this.btdodajkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btdodajkierowcy.Image")));
            this.btdodajkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajkierowcy.Location = new System.Drawing.Point(61, 191);
            this.btdodajkierowcy.Name = "btdodajkierowcy";
            this.btdodajkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btdodajkierowcy.TabIndex = 23;
            this.btdodajkierowcy.Text = "Dodaj";
            this.btdodajkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajkierowcy.UseVisualStyleBackColor = true;
            this.btdodajkierowcy.Click += new System.EventHandler(this.btdodajkierowcy_Click);
            // 
            // btszukajkierowcy
            // 
            this.btszukajkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btszukajkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btszukajkierowcy.Image")));
            this.btszukajkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btszukajkierowcy.Location = new System.Drawing.Point(61, 135);
            this.btszukajkierowcy.Name = "btszukajkierowcy";
            this.btszukajkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btszukajkierowcy.TabIndex = 22;
            this.btszukajkierowcy.Text = "Wyszukaj";
            this.btszukajkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btszukajkierowcy.UseVisualStyleBackColor = true;
            this.btszukajkierowcy.Click += new System.EventHandler(this.btszukajkierowcy_Click);
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
            // btcbkierowcy
            // 
            this.btcbkierowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbkierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btcbkierowcy.Image")));
            this.btcbkierowcy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbkierowcy.Location = new System.Drawing.Point(773, 439);
            this.btcbkierowcy.Name = "btcbkierowcy";
            this.btcbkierowcy.Size = new System.Drawing.Size(159, 50);
            this.btcbkierowcy.TabIndex = 0;
            this.btcbkierowcy.Text = "Powrót";
            this.btcbkierowcy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbkierowcy.UseVisualStyleBackColor = true;
            this.btcbkierowcy.Click += new System.EventHandler(this.btcbkierowcy_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieNazwiskoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bskierowcywtr;
            this.dataGridView2.Location = new System.Drawing.Point(627, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(145, 139);
            this.dataGridView2.TabIndex = 28;
            // 
            // imieNazwiskoDataGridViewTextBoxColumn1
            // 
            this.imieNazwiskoDataGridViewTextBoxColumn1.DataPropertyName = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn1.HeaderText = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn1.Name = "imieNazwiskoDataGridViewTextBoxColumn1";
            this.imieNazwiskoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bskierowcywtr
            // 
            this.bskierowcywtr.DataSource = typeof(Baza_PKS.Kierowca);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(623, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Aktualnie w trasie";
            // 
            // bskurs
            // 
            this.bskurs.DataSource = typeof(Baza_PKS.Kurs);
            // 
            // frmkierowcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbdanekierowcy);
            this.Controls.Add(this.btusunkierowcy);
            this.Controls.Add(this.btedytujkierowcy);
            this.Controls.Add(this.btdodajkierowcy);
            this.Controls.Add(this.btszukajkierowcy);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btcbkierowcy);
            this.Name = "frmkierowcy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kierowcy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowcywtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbkierowcy;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btusunkierowcy;
        private System.Windows.Forms.Button btedytujkierowcy;
        private System.Windows.Forms.Button btdodajkierowcy;
        private System.Windows.Forms.Button btszukajkierowcy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbdanekierowcy;
        private System.Windows.Forms.BindingSource bskierowcy;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieNazwiskoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bskierowcywtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bskurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
    }
}