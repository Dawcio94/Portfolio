namespace Baza_PKS
{
    partial class frmmiejscowosci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmiejscowosci));
            this.btcbmiejscowosci = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btusunmiejscowosci = new System.Windows.Forms.Button();
            this.btedytujmiejscowosci = new System.Windows.Forms.Button();
            this.btdodajmiejscowosci = new System.Windows.Forms.Button();
            this.dgmiejscowosci = new System.Windows.Forms.DataGridView();
            this.Id_miejscowosci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbdanemiejscowosci = new System.Windows.Forms.Label();
            this.nazwamiejscowosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsmiejscowosci = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmiejscowosci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiejscowosci)).BeginInit();
            this.SuspendLayout();
            // 
            // btcbmiejscowosci
            // 
            this.btcbmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btcbmiejscowosci.Image")));
            this.btcbmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbmiejscowosci.Location = new System.Drawing.Point(773, 439);
            this.btcbmiejscowosci.Name = "btcbmiejscowosci";
            this.btcbmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btcbmiejscowosci.TabIndex = 0;
            this.btcbmiejscowosci.Text = "Powrót";
            this.btcbmiejscowosci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbmiejscowosci.UseVisualStyleBackColor = true;
            this.btcbmiejscowosci.Click += new System.EventHandler(this.btcbmiejscowosci_Click);
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
            // btusunmiejscowosci
            // 
            this.btusunmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusunmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btusunmiejscowosci.Image")));
            this.btusunmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusunmiejscowosci.Location = new System.Drawing.Point(61, 303);
            this.btusunmiejscowosci.Name = "btusunmiejscowosci";
            this.btusunmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btusunmiejscowosci.TabIndex = 27;
            this.btusunmiejscowosci.Text = "Usuń";
            this.btusunmiejscowosci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusunmiejscowosci.UseVisualStyleBackColor = true;
            this.btusunmiejscowosci.Click += new System.EventHandler(this.btusunmiejscowosci_Click);
            // 
            // btedytujmiejscowosci
            // 
            this.btedytujmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btedytujmiejscowosci.Image")));
            this.btedytujmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujmiejscowosci.Location = new System.Drawing.Point(61, 247);
            this.btedytujmiejscowosci.Name = "btedytujmiejscowosci";
            this.btedytujmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btedytujmiejscowosci.TabIndex = 26;
            this.btedytujmiejscowosci.Text = "Edytuj";
            this.btedytujmiejscowosci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujmiejscowosci.UseVisualStyleBackColor = true;
            this.btedytujmiejscowosci.Click += new System.EventHandler(this.btedytujmiejscowosci_Click);
            // 
            // btdodajmiejscowosci
            // 
            this.btdodajmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btdodajmiejscowosci.Image")));
            this.btdodajmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajmiejscowosci.Location = new System.Drawing.Point(61, 191);
            this.btdodajmiejscowosci.Name = "btdodajmiejscowosci";
            this.btdodajmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btdodajmiejscowosci.TabIndex = 25;
            this.btdodajmiejscowosci.Text = "Dodaj";
            this.btdodajmiejscowosci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajmiejscowosci.UseVisualStyleBackColor = true;
            this.btdodajmiejscowosci.Click += new System.EventHandler(this.btdodajmiejscowosci_Click);
            // 
            // dgmiejscowosci
            // 
            this.dgmiejscowosci.AllowUserToAddRows = false;
            this.dgmiejscowosci.AllowUserToDeleteRows = false;
            this.dgmiejscowosci.AutoGenerateColumns = false;
            this.dgmiejscowosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmiejscowosci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_miejscowosci,
            this.nazwamiejscowosciDataGridViewTextBoxColumn});
            this.dgmiejscowosci.DataSource = this.bsmiejscowosci;
            this.dgmiejscowosci.Location = new System.Drawing.Point(301, 175);
            this.dgmiejscowosci.Name = "dgmiejscowosci";
            this.dgmiejscowosci.ReadOnly = true;
            this.dgmiejscowosci.Size = new System.Drawing.Size(286, 150);
            this.dgmiejscowosci.TabIndex = 30;
            // 
            // Id_miejscowosci
            // 
            this.Id_miejscowosci.DataPropertyName = "Id_miejscowosci";
            this.Id_miejscowosci.HeaderText = "Id_miejscowosci";
            this.Id_miejscowosci.Name = "Id_miejscowosci";
            this.Id_miejscowosci.ReadOnly = true;
            // 
            // lbdanemiejscowosci
            // 
            this.lbdanemiejscowosci.AutoSize = true;
            this.lbdanemiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdanemiejscowosci.Location = new System.Drawing.Point(297, 152);
            this.lbdanemiejscowosci.Name = "lbdanemiejscowosci";
            this.lbdanemiejscowosci.Size = new System.Drawing.Size(144, 20);
            this.lbdanemiejscowosci.TabIndex = 29;
            this.lbdanemiejscowosci.Text = "Dane miejscowości";
            // 
            // nazwamiejscowosciDataGridViewTextBoxColumn
            // 
            this.nazwamiejscowosciDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_miejscowosci";
            this.nazwamiejscowosciDataGridViewTextBoxColumn.HeaderText = "Nazwa_miejscowosci";
            this.nazwamiejscowosciDataGridViewTextBoxColumn.Name = "nazwamiejscowosciDataGridViewTextBoxColumn";
            this.nazwamiejscowosciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsmiejscowosci
            // 
            this.bsmiejscowosci.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // frmmiejscowosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.dgmiejscowosci);
            this.Controls.Add(this.lbdanemiejscowosci);
            this.Controls.Add(this.btusunmiejscowosci);
            this.Controls.Add(this.btedytujmiejscowosci);
            this.Controls.Add(this.btdodajmiejscowosci);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btcbmiejscowosci);
            this.Name = "frmmiejscowosci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miejscowości";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmiejscowosci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiejscowosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbmiejscowosci;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btusunmiejscowosci;
        private System.Windows.Forms.Button btedytujmiejscowosci;
        private System.Windows.Forms.Button btdodajmiejscowosci;
        private System.Windows.Forms.DataGridView dgmiejscowosci;
        private System.Windows.Forms.Label lbdanemiejscowosci;
        private System.Windows.Forms.BindingSource bsmiejscowosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_miejscowosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwamiejscowosciDataGridViewTextBoxColumn;
    }
}