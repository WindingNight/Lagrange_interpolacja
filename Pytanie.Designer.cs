namespace Macierze_JR
{
    partial class Pytanie
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
            this.wprowadz = new System.Windows.Forms.Button();
            this.liczba_punktow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wprowadz
            // 
            this.wprowadz.Location = new System.Drawing.Point(114, 111);
            this.wprowadz.Name = "wprowadz";
            this.wprowadz.Size = new System.Drawing.Size(75, 23);
            this.wprowadz.TabIndex = 0;
            this.wprowadz.Text = "Wprowadz";
            this.wprowadz.UseVisualStyleBackColor = true;
            this.wprowadz.Click += new System.EventHandler(this.wprowadz_Click);
            // 
            // liczba_punktow
            // 
            this.liczba_punktow.Location = new System.Drawing.Point(125, 85);
            this.liczba_punktow.MaxLength = 10;
            this.liczba_punktow.Name = "liczba_punktow";
            this.liczba_punktow.Size = new System.Drawing.Size(54, 20);
            this.liczba_punktow.TabIndex = 1;
            this.liczba_punktow.TextChanged += new System.EventHandler(this.wiersze_1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wprowadź liczbę punktów";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "Witaj w programie obliczającym funkcję interpolacji Lagrange\'a!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Credits
            // 
            this.Credits.Location = new System.Drawing.Point(12, 166);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(133, 23);
            this.Credits.TabIndex = 11;
            this.Credits.Text = "O autorach i metodzie";
            this.Credits.UseVisualStyleBackColor = true;
            this.Credits.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 204);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liczba_punktow);
            this.Controls.Add(this.wprowadz);
            this.Name = "Pytanie";
            this.Text = "Dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wprowadz;
        private System.Windows.Forms.TextBox liczba_punktow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Credits;
    }
}