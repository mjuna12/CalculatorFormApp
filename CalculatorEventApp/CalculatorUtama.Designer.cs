namespace CalculatorEventApp
{
    partial class CalculatorUtama
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
            this.lvwHasil = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.Hasil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwHasil
            // 
            this.lvwHasil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hasil});
            this.lvwHasil.HideSelection = false;
            this.lvwHasil.Location = new System.Drawing.Point(21, 12);
            this.lvwHasil.Name = "lvwHasil";
            this.lvwHasil.Size = new System.Drawing.Size(429, 264);
            this.lvwHasil.TabIndex = 0;
            this.lvwHasil.UseCompatibleStateImageBehavior = false;
            this.lvwHasil.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwHasil);
            this.groupBox1.Location = new System.Drawing.Point(52, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(73, 335);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(428, 28);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Hasil
            // 
            this.Hasil.Width = 150;
            // 
            // CalculatorUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CalculatorUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.Load += new System.EventHandler(this.CalculatorUtama_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwHasil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ColumnHeader Hasil;
    }
}

