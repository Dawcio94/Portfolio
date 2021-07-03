namespace Baza_PKS
{
    partial class frmtrasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrasy));
            this.btcbtrasy = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.dgtrasy = new System.Windows.Forms.DataGridView();
            this.bstrasy = new System.Windows.Forms.BindingSource(this.components);
            this.lbdanetrasy = new System.Windows.Forms.Label();
            this.btusuntrasy = new System.Windows.Forms.Button();
            this.btedytujtrasy = new System.Windows.Forms.Button();
            this.btdodajtrasy = new System.Windows.Forms.Button();
            this.bsmiastopocz = new System.Windows.Forms.BindingSource(this.components);
            this.bsmiastokon = new System.Windows.Forms.BindingSource(this.components);
            this.Miejscowości = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miejscowości1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaczenietrasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtrasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstrasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastopocz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastokon)).BeginInit();
            this.SuspendLayout();
            // 
            // btcbtrasy
            // 
            this.btcbtrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcbtrasy.Image = ((System.Drawing.Image)(resources.GetObject("btcbtrasy.Image")));
            this.btcbtrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcbtrasy.Location = new System.Drawing.Point(773, 439);
            this.btcbtrasy.Name = "btcbtrasy";
            this.btcbtrasy.Size = new System.Drawing.Size(159, 50);
            this.btcbtrasy.TabIndex = 0;
            this.btcbtrasy.Text = "Powrót";
            this.btcbtrasy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcbtrasy.UseVisualStyleBackColor = true;
            this.btcbtrasy.Click += new System.EventHandler(this.btcbtrasy_Click);
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
            // dgtrasy
            // 
            this.dgtrasy.AllowUserToAddRows = false;
            this.dgtrasy.AllowUserToDeleteRows = false;
            this.dgtrasy.AutoGenerateColumns = false;
            this.dgtrasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtrasy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Miejscowości,
            this.Miejscowości1,
            this.oznaczenietrasyDataGridViewTextBoxColumn});
            this.dgtrasy.DataSource = this.bstrasy;
            this.dgtrasy.Location = new System.Drawing.Point(301, 191);
            this.dgtrasy.Name = "dgtrasy";
            this.dgtrasy.ReadOnly = true;
            this.dgtrasy.Size = new System.Drawing.Size(345, 150);
            this.dgtrasy.TabIndex = 35;
            // 
            // bstrasy
            // 
            this.bstrasy.DataSource = typeof(Baza_PKS.Trasa);
            // 
            // lbdanetrasy
            // 
            this.lbdanetrasy.AutoSize = true;
            this.lbdanetrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdanetrasy.Location = new System.Drawing.Point(297, 152);
            this.lbdanetrasy.Name = "lbdanetrasy";
            this.lbdanetrasy.Size = new System.Drawing.Size(86, 20);
            this.lbdanetrasy.TabIndex = 34;
            this.lbdanetrasy.Text = "Dane trasy";
            // 
            // btusuntrasy
            // 
            this.btusuntrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btusuntrasy.Image = ((System.Drawing.Image)(resources.GetObject("btusuntrasy.Image")));
            this.btusuntrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusuntrasy.Location = new System.Drawing.Point(61, 303);
            this.btusuntrasy.Name = "btusuntrasy";
            this.btusuntrasy.Size = new System.Drawing.Size(159, 50);
            this.btusuntrasy.TabIndex = 33;
            this.btusuntrasy.Text = "Usuń";
            this.btusuntrasy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btusuntrasy.UseVisualStyleBackColor = true;
            this.btusuntrasy.Click += new System.EventHandler(this.btusuntrasy_Click);
            // 
            // btedytujtrasy
            // 
            this.btedytujtrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btedytujtrasy.Image = ((System.Drawing.Image)(resources.GetObject("btedytujtrasy.Image")));
            this.btedytujtrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedytujtrasy.Location = new System.Drawing.Point(61, 247);
            this.btedytujtrasy.Name = "btedytujtrasy";
            this.btedytujtrasy.Size = new System.Drawing.Size(159, 50);
            this.btedytujtrasy.TabIndex = 32;
            this.btedytujtrasy.Text = "Edytuj";
            this.btedytujtrasy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedytujtrasy.UseVisualStyleBackColor = true;
            this.btedytujtrasy.Click += new System.EventHandler(this.btedytujtrasy_Click);
            // 
            // btdodajtrasy
            // 
            this.btdodajtrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btdodajtrasy.Image = ((System.Drawing.Image)(resources.GetObject("btdodajtrasy.Image")));
            this.btdodajtrasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdodajtrasy.Location = new System.Drawing.Point(61, 191);
            this.btdodajtrasy.Name = "btdodajtrasy";
            this.btdodajtrasy.Size = new System.Drawing.Size(159, 50);
            this.btdodajtrasy.TabIndex = 31;
            this.btdodajtrasy.Text = "Dodaj";
            this.btdodajtrasy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdodajtrasy.UseVisualStyleBackColor = true;
            this.btdodajtrasy.Click += new System.EventHandler(this.btdodajtrasy_Click);
            // 
            // bsmiastopocz
            // 
            this.bsmiastopocz.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // bsmiastokon
            // 
            this.bsmiastokon.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // Miejscowości
            // 
            this.Miejscowości.DataPropertyName = "Miejscowości";
            this.Miejscowości.HeaderText = "Miejscowość począt";
            this.Miejscowości.Name = "Miejscowości";
            this.Miejscowości.ReadOnly = true;
            // 
            // Miejscowości1
            // 
            this.Miejscowości1.DataPropertyName = "Miejscowości1";
            this.Miejscowości1.HeaderText = "Miejscowość koniec";
            this.Miejscowości1.Name = "Miejscowości1";
            this.Miejscowości1.ReadOnly = true;
            // 
            // oznaczenietrasyDataGridViewTextBoxColumn
            // 
            this.oznaczenietrasyDataGridViewTextBoxColumn.DataPropertyName = "Oznaczenie_trasy";
            this.oznaczenietrasyDataGridViewTextBoxColumn.HeaderText = "Oznaczenie_trasy";
            this.oznaczenietrasyDataGridViewTextBoxColumn.Name = "oznaczenietrasyDataGridViewTextBoxColumn";
            this.oznaczenietrasyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmtrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.dgtrasy);
            this.Controls.Add(this.lbdanetrasy);
            this.Controls.Add(this.btusuntrasy);
            this.Controls.Add(this.btedytujtrasy);
            this.Controls.Add(this.btdodajtrasy);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btcbtrasy);
            this.Name = "frmtrasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trasy";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtrasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstrasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastopocz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiastokon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcbtrasy;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.DataGridView dgtrasy;
        private System.Windows.Forms.Label lbdanetrasy;
        private System.Windows.Forms.Button btusuntrasy;
        private System.Windows.Forms.Button btedytujtrasy;
        private System.Windows.Forms.Button btdodajtrasy;
        private System.Windows.Forms.BindingSource bstrasy;
        private System.Windows.Forms.BindingSource bsmiastopocz;
        private System.Windows.Forms.BindingSource bsmiastokon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejscowości;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejscowości1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaczenietrasyDataGridViewTextBoxColumn;
    }
}