namespace Baza_PKS
{
    partial class frmmiejscowosciedycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmiejscowosciedycja));
            this.btaneditmiejscowosci = new System.Windows.Forms.Button();
            this.btokeditmiejscowosci = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.tbnazwamiejscowosci = new System.Windows.Forms.TextBox();
            this.lbnazwamiejscowsci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btaneditmiejscowosci
            // 
            this.btaneditmiejscowosci.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btaneditmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btaneditmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btaneditmiejscowosci.Image")));
            this.btaneditmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaneditmiejscowosci.Location = new System.Drawing.Point(230, 200);
            this.btaneditmiejscowosci.Name = "btaneditmiejscowosci";
            this.btaneditmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btaneditmiejscowosci.TabIndex = 29;
            this.btaneditmiejscowosci.Text = "Anuluj";
            this.btaneditmiejscowosci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaneditmiejscowosci.UseVisualStyleBackColor = true;
            this.btaneditmiejscowosci.Click += new System.EventHandler(this.btaneditmiejscowosci_Click);
            // 
            // btokeditmiejscowosci
            // 
            this.btokeditmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokeditmiejscowosci.Image = ((System.Drawing.Image)(resources.GetObject("btokeditmiejscowosci.Image")));
            this.btokeditmiejscowosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokeditmiejscowosci.Location = new System.Drawing.Point(65, 200);
            this.btokeditmiejscowosci.Name = "btokeditmiejscowosci";
            this.btokeditmiejscowosci.Size = new System.Drawing.Size(159, 50);
            this.btokeditmiejscowosci.TabIndex = 28;
            this.btokeditmiejscowosci.Text = "OK";
            this.btokeditmiejscowosci.UseVisualStyleBackColor = true;
            this.btokeditmiejscowosci.Click += new System.EventHandler(this.btokeditmiejscowosci_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Baza_PKS.Properties.Resources.logo;
            this.pblogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pblogo.InitialImage")));
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(89, 88);
            this.pblogo.TabIndex = 27;
            this.pblogo.TabStop = false;
            // 
            // tbnazwamiejscowosci
            // 
            this.tbnazwamiejscowosci.Location = new System.Drawing.Point(152, 140);
            this.tbnazwamiejscowosci.Name = "tbnazwamiejscowosci";
            this.tbnazwamiejscowosci.Size = new System.Drawing.Size(156, 20);
            this.tbnazwamiejscowosci.TabIndex = 26;
            // 
            // lbnazwamiejscowsci
            // 
            this.lbnazwamiejscowsci.AutoSize = true;
            this.lbnazwamiejscowsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbnazwamiejscowsci.Location = new System.Drawing.Point(151, 117);
            this.lbnazwamiejscowsci.Name = "lbnazwamiejscowsci";
            this.lbnazwamiejscowsci.Size = new System.Drawing.Size(157, 20);
            this.lbnazwamiejscowsci.TabIndex = 25;
            this.lbnazwamiejscowsci.Text = "Nazwa miejscowosci:";
            // 
            // frmmiejscowosciedycja
            // 
            this.AcceptButton = this.btokeditmiejscowosci;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btaneditmiejscowosci;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.btaneditmiejscowosci);
            this.Controls.Add(this.btokeditmiejscowosci);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.tbnazwamiejscowosci);
            this.Controls.Add(this.lbnazwamiejscowsci);
            this.Name = "frmmiejscowosciedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miejscowości";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btaneditmiejscowosci;
        private System.Windows.Forms.Button btokeditmiejscowosci;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox tbnazwamiejscowosci;
        private System.Windows.Forms.Label lbnazwamiejscowsci;
    }
}