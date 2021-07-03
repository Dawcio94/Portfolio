namespace Baza_PKS
{
    partial class frmprzebiegedycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprzebiegedycja));
            this.btokeditprzebieg = new System.Windows.Forms.Button();
            this.btaneditprzebieg = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lbmiejscowosci = new System.Windows.Forms.Label();
            this.lbrozczasu = new System.Windows.Forms.Label();
            this.lbidtrasy = new System.Windows.Forms.Label();
            this.lbkolejka = new System.Windows.Forms.Label();
            this.tbidtrasy = new System.Windows.Forms.TextBox();
            this.tbroznicaczasu = new System.Windows.Forms.TextBox();
            this.tbkolejnosc = new System.Windows.Forms.TextBox();
            this.cbmiasto = new System.Windows.Forms.ComboBox();
            this.bsmiasto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiasto)).BeginInit();
            this.SuspendLayout();
            // 
            // btokeditprzebieg
            // 
            this.btokeditprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btokeditprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btokeditprzebieg.Image")));
            this.btokeditprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btokeditprzebieg.Location = new System.Drawing.Point(56, 223);
            this.btokeditprzebieg.Name = "btokeditprzebieg";
            this.btokeditprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btokeditprzebieg.TabIndex = 0;
            this.btokeditprzebieg.Text = "OK";
            this.btokeditprzebieg.UseVisualStyleBackColor = true;
            this.btokeditprzebieg.Click += new System.EventHandler(this.btokeditprzebieg_Click);
            // 
            // btaneditprzebieg
            // 
            this.btaneditprzebieg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btaneditprzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btaneditprzebieg.Image = ((System.Drawing.Image)(resources.GetObject("btaneditprzebieg.Image")));
            this.btaneditprzebieg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaneditprzebieg.Location = new System.Drawing.Point(221, 223);
            this.btaneditprzebieg.Name = "btaneditprzebieg";
            this.btaneditprzebieg.Size = new System.Drawing.Size(159, 50);
            this.btaneditprzebieg.TabIndex = 1;
            this.btaneditprzebieg.Text = "Anuluj";
            this.btaneditprzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaneditprzebieg.UseVisualStyleBackColor = true;
            this.btaneditprzebieg.Click += new System.EventHandler(this.btaneditprzebieg_Click);
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
            // lbmiejscowosci
            // 
            this.lbmiejscowosci.AutoSize = true;
            this.lbmiejscowosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbmiejscowosci.Location = new System.Drawing.Point(69, 112);
            this.lbmiejscowosci.Name = "lbmiejscowosci";
            this.lbmiejscowosci.Size = new System.Drawing.Size(157, 20);
            this.lbmiejscowosci.TabIndex = 24;
            this.lbmiejscowosci.Text = "Nazwa miejscowości:";
            // 
            // lbrozczasu
            // 
            this.lbrozczasu.AutoSize = true;
            this.lbrozczasu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbrozczasu.Location = new System.Drawing.Point(69, 158);
            this.lbrozczasu.Name = "lbrozczasu";
            this.lbrozczasu.Size = new System.Drawing.Size(117, 20);
            this.lbrozczasu.TabIndex = 25;
            this.lbrozczasu.Text = "Różnica czasu:";
            // 
            // lbidtrasy
            // 
            this.lbidtrasy.AutoSize = true;
            this.lbidtrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbidtrasy.Location = new System.Drawing.Point(69, 136);
            this.lbidtrasy.Name = "lbidtrasy";
            this.lbidtrasy.Size = new System.Drawing.Size(135, 20);
            this.lbidtrasy.TabIndex = 26;
            this.lbidtrasy.Text = "Oznaczenie trasy:";
            // 
            // lbkolejka
            // 
            this.lbkolejka.AutoSize = true;
            this.lbkolejka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbkolejka.Location = new System.Drawing.Point(69, 181);
            this.lbkolejka.Name = "lbkolejka";
            this.lbkolejka.Size = new System.Drawing.Size(81, 20);
            this.lbkolejka.TabIndex = 27;
            this.lbkolejka.Text = "Kolejność:";
            // 
            // tbidtrasy
            // 
            this.tbidtrasy.Location = new System.Drawing.Point(210, 136);
            this.tbidtrasy.Name = "tbidtrasy";
            this.tbidtrasy.Size = new System.Drawing.Size(158, 20);
            this.tbidtrasy.TabIndex = 29;
            // 
            // tbroznicaczasu
            // 
            this.tbroznicaczasu.Location = new System.Drawing.Point(192, 158);
            this.tbroznicaczasu.Name = "tbroznicaczasu";
            this.tbroznicaczasu.Size = new System.Drawing.Size(176, 20);
            this.tbroznicaczasu.TabIndex = 30;
            // 
            // tbkolejnosc
            // 
            this.tbkolejnosc.Location = new System.Drawing.Point(156, 181);
            this.tbkolejnosc.Name = "tbkolejnosc";
            this.tbkolejnosc.Size = new System.Drawing.Size(212, 20);
            this.tbkolejnosc.TabIndex = 31;
            // 
            // cbmiasto
            // 
            this.cbmiasto.DataSource = this.bsmiasto;
            this.cbmiasto.DisplayMember = "Nazwa_miejscowosci";
            this.cbmiasto.FormattingEnabled = true;
            this.cbmiasto.Location = new System.Drawing.Point(232, 112);
            this.cbmiasto.Name = "cbmiasto";
            this.cbmiasto.Size = new System.Drawing.Size(136, 21);
            this.cbmiasto.TabIndex = 32;
            // 
            // bsmiasto
            // 
            this.bsmiasto.DataSource = typeof(Baza_PKS.Miejscowości);
            // 
            // frmprzebiegedycja
            // 
            this.AcceptButton = this.btokeditprzebieg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btaneditprzebieg;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.cbmiasto);
            this.Controls.Add(this.tbkolejnosc);
            this.Controls.Add(this.tbroznicaczasu);
            this.Controls.Add(this.tbidtrasy);
            this.Controls.Add(this.lbkolejka);
            this.Controls.Add(this.lbidtrasy);
            this.Controls.Add(this.lbrozczasu);
            this.Controls.Add(this.lbmiejscowosci);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btaneditprzebieg);
            this.Controls.Add(this.btokeditprzebieg);
            this.Name = "frmprzebiegedycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przebieg";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmiasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btokeditprzebieg;
        private System.Windows.Forms.Button btaneditprzebieg;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lbmiejscowosci;
        private System.Windows.Forms.Label lbrozczasu;
        private System.Windows.Forms.Label lbidtrasy;
        private System.Windows.Forms.Label lbkolejka;
        private System.Windows.Forms.TextBox tbidtrasy;
        private System.Windows.Forms.TextBox tbroznicaczasu;
        private System.Windows.Forms.TextBox tbkolejnosc;
        private System.Windows.Forms.ComboBox cbmiasto;
        private System.Windows.Forms.BindingSource bsmiasto;
    }
}