namespace Baza_PKS
{
    partial class frmlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlog));
            this.tblogin1 = new System.Windows.Forms.TextBox();
            this.tbhaslo1 = new System.Windows.Forms.TextBox();
            this.btlog = new System.Windows.Forms.Button();
            this.btcblog = new System.Windows.Forms.Button();
            this.lbhaslo = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblogin1
            // 
            this.tblogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblogin1.Location = new System.Drawing.Point(197, 105);
            this.tblogin1.Name = "tblogin1";
            this.tblogin1.Size = new System.Drawing.Size(140, 26);
            this.tblogin1.TabIndex = 2;
            // 
            // tbhaslo1
            // 
            this.tbhaslo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbhaslo1.Location = new System.Drawing.Point(197, 143);
            this.tbhaslo1.Name = "tbhaslo1";
            this.tbhaslo1.Size = new System.Drawing.Size(140, 26);
            this.tbhaslo1.TabIndex = 3;
            this.tbhaslo1.UseSystemPasswordChar = true;
            // 
            // btlog
            // 
            this.btlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btlog.Image = ((System.Drawing.Image)(resources.GetObject("btlog.Image")));
            this.btlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlog.Location = new System.Drawing.Point(81, 191);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(159, 50);
            this.btlog.TabIndex = 4;
            this.btlog.Text = "OK";
            this.btlog.UseVisualStyleBackColor = true;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btcblog
            // 
            this.btcblog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btcblog.Image = ((System.Drawing.Image)(resources.GetObject("btcblog.Image")));
            this.btcblog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcblog.Location = new System.Drawing.Point(246, 191);
            this.btcblog.Name = "btcblog";
            this.btcblog.Size = new System.Drawing.Size(159, 50);
            this.btcblog.TabIndex = 5;
            this.btcblog.Text = "Anuluj";
            this.btcblog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcblog.UseVisualStyleBackColor = true;
            this.btcblog.Click += new System.EventHandler(this.btcblog_Click);
            // 
            // lbhaslo
            // 
            this.lbhaslo.AutoSize = true;
            this.lbhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbhaslo.Location = new System.Drawing.Point(136, 146);
            this.lbhaslo.Name = "lbhaslo";
            this.lbhaslo.Size = new System.Drawing.Size(55, 20);
            this.lbhaslo.TabIndex = 6;
            this.lbhaslo.Text = "Hasło:";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblogin.Location = new System.Drawing.Point(136, 108);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(52, 20);
            this.lblogin.TabIndex = 7;
            this.lblogin.Text = "Login:";
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
            // frmlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 322);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.lbhaslo);
            this.Controls.Add(this.btcblog);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.tbhaslo1);
            this.Controls.Add(this.tblogin1);
            this.Name = "frmlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblogin1;
        private System.Windows.Forms.TextBox tbhaslo1;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btcblog;
        private System.Windows.Forms.Label lbhaslo;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.PictureBox pblogo;

    }
}