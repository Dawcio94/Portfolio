namespace Baza_PKS
{
    partial class frmprzebieg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprzebieg));
            this.btcbprzebieg = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.dgprzebieg = new System.Windows.Forms.DataGridView();
            this.lbdaneprzebieg = new System.Windows.Forms.Label();
            this.btusunprzebieg = new System.Windows.Forms.Button();
            this.btedytujprzebieg = new System.Windows.Forms.Button();
            this.btdodajprzebieg = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bstrasy = new System.Windows.Forms.BindingSource(this.components);
            this.Miejscowości = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roznicaczasuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolejnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsprzebieg = new System.Windows.Forms.BindingSource(this.components);
            this.oznaczenietrasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgprzebieg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstrasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprzebieg)).BeginInit();
            this.SuspendLayout();
            // 
            // btcbprzebieg
            // 
            this.btcbprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btcbprzebieg.Image")));
            this.btcbprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbprzebieg.Location = new System.Drawing.Point(773, 439);
            this.btcbprzebieg.Name = "btcbprzebieg";
            this.btcbprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btcbprzebieg.TabIndex = 0;
            this.btcbprzebieg.Text = "Powrót";
            this.btcbprzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbprzebieg.UseVisualStyleBackColor = true;
            this.btcbprzebieg.Click += new System.EventHandler(this.btcbprzebieg_Click);
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
            // dgprzebieg
            // 
            this.dgprzebieg.AllowUserToAddRows = false;
            this.dgprzebieg.AllowUserToDeleteRows = false;
            this.dgprzebieg.AutoGenerateColumns = false;
            this.dgprzebieg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprzebieg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Miejscowości,
            this.roznicaczasuDataGridViewTextBoxColumn,
            this.kolejnoscDataGridViewTextBoxColumn});
            this.dgprzebieg.DataSource = this.bsprzebieg;
            this.dgprzebieg.Location = new System.Drawing.Point(451, 191);
            this.dgprzebieg.Name = "dgprzebieg";
            this.dgprzebieg.ReadOnly = true;
            this.dgprzebieg.Size = new System.Drawing.Size(344, 150);
            this.dgprzebieg.TabIndex = 40;
            // 
            // lbdaneprzebieg
            // 
            this.lbdaneprzebieg.AutoSize = true;
            this.lbdaneprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdaneprzebieg.Location = new System.Drawing.Point(297, 152);
            this.lbdaneprzebieg.Name = "lbdaneprzebieg";
            this.lbdaneprzebieg.Size = new System.Drawing.Size(122, 20);
            this.lbdaneprzebieg.TabIndex = 39;
            this.lbdaneprzebieg.Text = "Dane przebiegu";
            // 
            // btusunprzebieg
            // 
            this.btusunprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusunprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btusunprzebieg.Image")));
            this.btusunprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusunprzebieg.Location = new System.Drawing.Point(61, 303);
            this.btusunprzebieg.Name = "btusunprzebieg";
            this.btusunprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btusunprzebieg.TabIndex = 38;
            this.btusunprzebieg.Text = "Usuń";
            this.btusunprzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusunprzebieg.UseVisualStyleBackColor = true;
            this.btusunprzebieg.Click += new System.EventHandler(this.btusunprzebieg_Click);
            // 
            // btedytujprzebieg
            // 
            this.btedytujprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btedytujprzebieg.Image")));
            this.btedytujprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujprzebieg.Location = new System.Drawing.Point(61, 247);
            this.btedytujprzebieg.Name = "btedytujprzebieg";
            this.btedytujprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btedytujprzebieg.TabIndex = 37;
            this.btedytujprzebieg.Text = "Edytuj";
            this.btedytujprzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujprzebieg.UseVisualStyleBackColor = true;
            this.btedytujprzebieg.Click += new System.EventHandler(this.btedytujprzebieg_Click);
            // 
            // btdodajprzebieg
            // 
            this.btdodajprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btdodajprzebieg.Image")));
            this.btdodajprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajprzebieg.Location = new System.Drawing.Point(61, 191);
            this.btdodajprzebieg.Name = "btdodajprzebieg";
            this.btdodajprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btdodajprzebieg.TabIndex = 36;
            this.btdodajprzebieg.Text = "Dodaj";
            this.btdodajprzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajprzebieg.UseVisualStyleBackColor = true;
            this.btdodajprzebieg.Click += new System.EventHandler(this.btdodajprzebieg_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oznaczenietrasyDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bstrasy;
            this.dataGridView2.Location = new System.Drawing.Point(301, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(144, 150);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bstrasy
            // 
            this.bstrasy.DataSource = typeof(Baza_PKS.Trasa);
            // 
            // Miejscowości
            // 
            this.Miejscowości.DataPropertyName = "Miejscowości";
            this.Miejscowości.HeaderText = "Miejscowości";
            this.Miejscowości.Name = "Miejscowości";
            this.Miejscowości.ReadOnly = true;
            // 
            // roznicaczasuDataGridViewTextBoxColumn
            // 
            this.roznicaczasuDataGridViewTextBoxColumn.DataPropertyName = "Roznica_czasu";
            this.roznicaczasuDataGridViewTextBoxColumn.HeaderText = "Roznica_czasu";
            this.roznicaczasuDataGridViewTextBoxColumn.Name = "roznicaczasuDataGridViewTextBoxColumn";
            this.roznicaczasuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolejnoscDataGridViewTextBoxColumn
            // 
            this.kolejnoscDataGridViewTextBoxColumn.DataPropertyName = "Kolejnosc";
            this.kolejnoscDataGridViewTextBoxColumn.HeaderText = "Kolejnosc";
            this.kolejnoscDataGridViewTextBoxColumn.Name = "kolejnoscDataGridViewTextBoxColumn";
            this.kolejnoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsprzebieg
            // 
            this.bsprzebieg.DataSource = typeof(Baza_PKS.Przebieg);
            // 
            // oznaczenietrasyDataGridViewTextBoxColumn
            // 
            this.oznaczenietrasyDataGridViewTextBoxColumn.DataPropertyName = "Oznaczenie_trasy";
            this.oznaczenietrasyDataGridViewTextBoxColumn.HeaderText = "Oznaczenie_trasy";
            this.oznaczenietrasyDataGridViewTextBoxColumn.Name = "oznaczenietrasyDataGridViewTextBoxColumn";
            this.oznaczenietrasyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmprzebieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgprzebieg);
            this.Controls.Add(this.lbdaneprzebieg);
            this.Controls.Add(this.btusunprzebieg);
            this.Controls.Add(this.btedytujprzebieg);
            this.Controls.Add(this.btdodajprzebieg);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btcbprzebieg);
            this.Name = "frmprzebieg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przebieg";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgprzebieg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstrasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprzebieg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbprzebieg;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.DataGridView dgprzebieg;
        private System.Windows.Forms.Label lbdaneprzebieg;
        private System.Windows.Forms.Button btusunprzebieg;
        private System.Windows.Forms.Button btedytujprzebieg;
        private System.Windows.Forms.Button btdodajprzebieg;
        private System.Windows.Forms.BindingSource bsprzebieg;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bstrasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejscowości;
        private System.Windows.Forms.DataGridViewTextBoxColumn roznicaczasuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolejnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaczenietrasyDataGridViewTextBoxColumn;
    }
}