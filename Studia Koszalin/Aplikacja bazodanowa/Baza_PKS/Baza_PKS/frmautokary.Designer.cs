namespace Baza_PKS
{
    partial class frmautokary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmautokary));
            this.lbdaneautoakru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgautokary = new System.Windows.Forms.DataGridView();
            this.nrrejestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbamiejscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsautokar = new System.Windows.Forms.BindingSource(this.components);
            this.dgkierowcy = new System.Windows.Forms.DataGridView();
            this.imieNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bskierowca = new System.Windows.Forms.BindingSource(this.components);
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btusunautokary = new System.Windows.Forms.Button();
            this.btedytujautokary = new System.Windows.Forms.Button();
            this.btdodajautokary = new System.Windows.Forms.Button();
            this.btszukajautokary = new System.Windows.Forms.Button();
            this.btcbautokary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgautokary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsautokar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkierowcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdaneautoakru
            // 
            this.lbdaneautoakru.AutoSize = true;
            this.lbdaneautoakru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdaneautoakru.Location = new System.Drawing.Point(276, 79);
            this.lbdaneautoakru.Name = "lbdaneautoakru";
            this.lbdaneautoakru.Size = new System.Drawing.Size(115, 20);
            this.lbdaneautoakru.TabIndex = 5;
            this.lbdaneautoakru.Text = "Dane autokaru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(276, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dane kierowcy";
            // 
            // dgautokary
            // 
            this.dgautokary.AllowUserToAddRows = false;
            this.dgautokary.AllowUserToDeleteRows = false;
            this.dgautokary.AutoGenerateColumns = false;
            this.dgautokary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgautokary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrrejestrDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.liczbamiejscDataGridViewTextBoxColumn,
            this.Kurs});
            this.dgautokary.DataSource = this.bsautokar;
            this.dgautokary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgautokary.Location = new System.Drawing.Point(280, 102);
            this.dgautokary.Name = "dgautokary";
            this.dgautokary.ReadOnly = true;
            this.dgautokary.Size = new System.Drawing.Size(543, 139);
            this.dgautokary.TabIndex = 7;
            // 
            // nrrejestrDataGridViewTextBoxColumn
            // 
            this.nrrejestrDataGridViewTextBoxColumn.DataPropertyName = "Nr_rejestr";
            this.nrrejestrDataGridViewTextBoxColumn.HeaderText = "Nr_rejestr";
            this.nrrejestrDataGridViewTextBoxColumn.Name = "nrrejestrDataGridViewTextBoxColumn";
            this.nrrejestrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // liczbamiejscDataGridViewTextBoxColumn
            // 
            this.liczbamiejscDataGridViewTextBoxColumn.DataPropertyName = "Liczba_miejsc";
            this.liczbamiejscDataGridViewTextBoxColumn.HeaderText = "Liczba_miejsc";
            this.liczbamiejscDataGridViewTextBoxColumn.Name = "liczbamiejscDataGridViewTextBoxColumn";
            this.liczbamiejscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // bsautokar
            // 
            this.bsautokar.DataSource = typeof(Baza_PKS.Autokar);
            // 
            // dgkierowcy
            // 
            this.dgkierowcy.AllowUserToAddRows = false;
            this.dgkierowcy.AllowUserToDeleteRows = false;
            this.dgkierowcy.AutoGenerateColumns = false;
            this.dgkierowcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkierowcy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieNazwiskoDataGridViewTextBoxColumn});
            this.dgkierowcy.DataSource = this.bskierowca;
            this.dgkierowcy.Location = new System.Drawing.Point(280, 294);
            this.dgkierowcy.Name = "dgkierowcy";
            this.dgkierowcy.ReadOnly = true;
            this.dgkierowcy.Size = new System.Drawing.Size(240, 139);
            this.dgkierowcy.TabIndex = 8;
            // 
            // imieNazwiskoDataGridViewTextBoxColumn
            // 
            this.imieNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.HeaderText = "Imie_Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.Name = "imieNazwiskoDataGridViewTextBoxColumn";
            this.imieNazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bskierowca
            // 
            this.bskierowca.DataSource = typeof(Baza_PKS.Kierowca);
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
            // btusunautokary
            // 
            this.btusunautokary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusunautokary.Image = ((System.Drawing.Image)(resources.GetObject("btusunautokary.Image")));
            this.btusunautokary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusunautokary.Location = new System.Drawing.Point(61, 303);
            this.btusunautokary.Name = "btusunautokary";
            this.btusunautokary.Size = new System.Drawing.Size(159, 50);
            this.btusunautokary.TabIndex = 4;
            this.btusunautokary.Text = "Usuń";
            this.btusunautokary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusunautokary.UseVisualStyleBackColor = true;
            this.btusunautokary.Click += new System.EventHandler(this.btusunautokary_Click);
            // 
            // btedytujautokary
            // 
            this.btedytujautokary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujautokary.Image = ((System.Drawing.Image)(resources.GetObject("btedytujautokary.Image")));
            this.btedytujautokary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujautokary.Location = new System.Drawing.Point(61, 247);
            this.btedytujautokary.Name = "btedytujautokary";
            this.btedytujautokary.Size = new System.Drawing.Size(159, 50);
            this.btedytujautokary.TabIndex = 3;
            this.btedytujautokary.Text = "Edytuj";
            this.btedytujautokary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujautokary.UseVisualStyleBackColor = true;
            this.btedytujautokary.Click += new System.EventHandler(this.btedytujautokary_Click);
            // 
            // btdodajautokary
            // 
            this.btdodajautokary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajautokary.Image = ((System.Drawing.Image)(resources.GetObject("btdodajautokary.Image")));
            this.btdodajautokary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajautokary.Location = new System.Drawing.Point(61, 191);
            this.btdodajautokary.Name = "btdodajautokary";
            this.btdodajautokary.Size = new System.Drawing.Size(159, 50);
            this.btdodajautokary.TabIndex = 2;
            this.btdodajautokary.Text = "Dodaj";
            this.btdodajautokary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajautokary.UseVisualStyleBackColor = true;
            this.btdodajautokary.Click += new System.EventHandler(this.btdodajautokary_Click);
            // 
            // btszukajautokary
            // 
            this.btszukajautokary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btszukajautokary.Image = ((System.Drawing.Image)(resources.GetObject("btszukajautokary.Image")));
            this.btszukajautokary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btszukajautokary.Location = new System.Drawing.Point(61, 135);
            this.btszukajautokary.Name = "btszukajautokary";
            this.btszukajautokary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btszukajautokary.Size = new System.Drawing.Size(159, 50);
            this.btszukajautokary.TabIndex = 1;
            this.btszukajautokary.Text = "Wyszukaj";
            this.btszukajautokary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btszukajautokary.UseVisualStyleBackColor = true;
            this.btszukajautokary.Click += new System.EventHandler(this.btszukajautokary_Click);
            // 
            // btcbautokary
            // 
            this.btcbautokary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbautokary.Image = ((System.Drawing.Image)(resources.GetObject("btcbautokary.Image")));
            this.btcbautokary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbautokary.Location = new System.Drawing.Point(773, 439);
            this.btcbautokary.Name = "btcbautokary";
            this.btcbautokary.Size = new System.Drawing.Size(159, 50);
            this.btcbautokary.TabIndex = 0;
            this.btcbautokary.Text = "Powrót";
            this.btcbautokary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbautokary.UseVisualStyleBackColor = true;
            this.btcbautokary.Click += new System.EventHandler(this.btcbautokary_Click);
            // 
            // frmautokary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.dgkierowcy);
            this.Controls.Add(this.dgautokary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdaneautoakru);
            this.Controls.Add(this.btusunautokary);
            this.Controls.Add(this.btedytujautokary);
            this.Controls.Add(this.btdodajautokary);
            this.Controls.Add(this.btszukajautokary);
            this.Controls.Add(this.btcbautokary);
            this.Name = "frmautokary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autokary";
            ((System.ComponentModel.ISupportInitialize)(this.dgautokary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsautokar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkierowcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskierowca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbautokary;
        private System.Windows.Forms.Button btszukajautokary;
        private System.Windows.Forms.Button btdodajautokary;
        private System.Windows.Forms.Button btedytujautokary;
        private System.Windows.Forms.Button btusunautokary;
        private System.Windows.Forms.Label lbdaneautoakru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgautokary;
        private System.Windows.Forms.DataGridView dgkierowcy;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.BindingSource bsautokar;
        private System.Windows.Forms.BindingSource bskierowca;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrrejestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbamiejscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
    }
}