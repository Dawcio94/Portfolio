namespace Studenci
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.btaverage = new System.Windows.Forms.Button();
            this.btmedian = new System.Windows.Forms.Button();
            this.btstandard = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Programming = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(45, 188);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 66);
            this.Add.TabIndex = 0;
            this.Add.Text = "Dodaj";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(45, 260);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(169, 61);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Usuń";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(45, 327);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(169, 61);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edytuj";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(45, 116);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(169, 66);
            this.Search.TabIndex = 3;
            this.Search.Text = "Wyszukaj";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btaverage
            // 
            this.btaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btaverage.Image = ((System.Drawing.Image)(resources.GetObject("btaverage.Image")));
            this.btaverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaverage.Location = new System.Drawing.Point(45, 471);
            this.btaverage.Name = "btaverage";
            this.btaverage.Size = new System.Drawing.Size(169, 61);
            this.btaverage.TabIndex = 4;
            this.btaverage.Text = "Średnia";
            this.btaverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaverage.UseVisualStyleBackColor = true;
            this.btaverage.Click += new System.EventHandler(this.btaverage_Click);
            // 
            // btmedian
            // 
            this.btmedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btmedian.Image = ((System.Drawing.Image)(resources.GetObject("btmedian.Image")));
            this.btmedian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmedian.Location = new System.Drawing.Point(220, 471);
            this.btmedian.Name = "btmedian";
            this.btmedian.Size = new System.Drawing.Size(169, 61);
            this.btmedian.TabIndex = 5;
            this.btmedian.Text = "Mediana";
            this.btmedian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmedian.UseVisualStyleBackColor = true;
            this.btmedian.Click += new System.EventHandler(this.btmedian_Click);
            // 
            // btstandard
            // 
            this.btstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btstandard.Image = ((System.Drawing.Image)(resources.GetObject("btstandard.Image")));
            this.btstandard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btstandard.Location = new System.Drawing.Point(395, 471);
            this.btstandard.Name = "btstandard";
            this.btstandard.Size = new System.Drawing.Size(169, 61);
            this.btstandard.TabIndex = 6;
            this.btstandard.Text = "Odchylenie standardowe";
            this.btstandard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btstandard.UseVisualStyleBackColor = true;
            this.btstandard.Click += new System.EventHandler(this.btstandard_Click);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.operation.Location = new System.Drawing.Point(570, 471);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(86, 31);
            this.operation.TabIndex = 7;
            this.operation.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(220, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Baza studentów Akademii Pomorskiej";
            // 
            // Students
            // 
            this.Students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Semester,
            this.Math,
            this.Programming,
            this.Average});
            this.Students.Enabled = false;
            this.Students.GridLines = true;
            this.Students.Location = new System.Drawing.Point(272, 116);
            this.Students.Name = "Students";
            this.Students.RightToLeftLayout = true;
            this.Students.Size = new System.Drawing.Size(622, 338);
            this.Students.TabIndex = 12;
            this.Students.UseCompatibleStateImageBehavior = false;
            this.Students.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Numer indeksu";
            this.Id.Width = 83;
            // 
            // Data
            // 
            this.Data.Text = "Imię i nazwisko";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Data.Width = 83;
            // 
            // Semester
            // 
            this.Semester.Text = "Semestr";
            this.Semester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Semester.Width = 50;
            // 
            // Math
            // 
            this.Math.Text = "Matematyka dyskretna";
            this.Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Math.Width = 119;
            // 
            // Programming
            // 
            this.Programming.Text = "Programowanie";
            this.Programming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Programming.Width = 85;
            // 
            // Average
            // 
            this.Average.Text = "Średnia";
            this.Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Average.Width = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(570, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(45, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Powrót";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.btstandard);
            this.Controls.Add(this.btmedian);
            this.Controls.Add(this.btaverage);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza danych studentów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btaverage;
        private System.Windows.Forms.Button btmedian;
        private System.Windows.Forms.Button btstandard;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Students;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.ColumnHeader Math;
        private System.Windows.Forms.ColumnHeader Average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Programming;
        private System.Windows.Forms.Button button1;
    }
}

