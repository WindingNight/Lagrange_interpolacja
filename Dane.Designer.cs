namespace Macierze_JR
{
    partial class Dane
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
            this.Oblicz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wprowadz = new System.Windows.Forms.Button();
            this.kolumnaX = new System.Windows.Forms.TableLayoutPanel();
            this.kolumnaY = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(399, 196);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(75, 23);
            this.Oblicz.TabIndex = 1;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.wprowadz);
            this.panel1.Controls.Add(this.kolumnaX);
            this.panel1.Controls.Add(this.kolumnaY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 200);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(203, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "wartość węzłów y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "węzły x";
            // 
            // wprowadz
            // 
            this.wprowadz.Location = new System.Drawing.Point(399, 34);
            this.wprowadz.Name = "wprowadz";
            this.wprowadz.Size = new System.Drawing.Size(75, 41);
            this.wprowadz.TabIndex = 7;
            this.wprowadz.Text = "Wprowadź dane";
            this.wprowadz.UseVisualStyleBackColor = true;
            this.wprowadz.Click += new System.EventHandler(this.wprowadz_Click_1);
            // 
            // kolumnaX
            // 
            this.kolumnaX.AutoSize = true;
            this.kolumnaX.ColumnCount = 1;
            this.kolumnaX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kolumnaX.Location = new System.Drawing.Point(15, 32);
            this.kolumnaX.Name = "kolumnaX";
            this.kolumnaX.RowCount = 1;
            this.kolumnaX.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kolumnaX.Size = new System.Drawing.Size(185, 159);
            this.kolumnaX.TabIndex = 6;
            // 
            // kolumnaY
            // 
            this.kolumnaY.AutoSize = true;
            this.kolumnaY.ColumnCount = 1;
            this.kolumnaY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kolumnaY.Location = new System.Drawing.Point(206, 32);
            this.kolumnaY.Name = "kolumnaY";
            this.kolumnaY.RowCount = 1;
            this.kolumnaY.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kolumnaY.Size = new System.Drawing.Size(174, 159);
            this.kolumnaY.TabIndex = 5;
            // 
            // Dane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Oblicz);
            this.Name = "Dane";
            this.Text = "Dane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel kolumnaX;
        private System.Windows.Forms.TableLayoutPanel kolumnaY;
        private System.Windows.Forms.Button wprowadz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

