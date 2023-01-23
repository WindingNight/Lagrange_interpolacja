namespace Macierze_JR
{
    partial class Wykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.szukana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.szukany_wynik = new System.Windows.Forms.TextBox();
            this.Szukaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.wzor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(11, 11);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(477, 244);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz szukany węzeł";
            // 
            // szukana
            // 
            this.szukana.Location = new System.Drawing.Point(494, 33);
            this.szukana.Margin = new System.Windows.Forms.Padding(2);
            this.szukana.Name = "szukana";
            this.szukana.Size = new System.Drawing.Size(68, 20);
            this.szukana.TabIndex = 2;
            this.szukana.TextChanged += new System.EventHandler(this.szukana_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(492, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wartość szukanego węzła wynosi:";
            // 
            // szukany_wynik
            // 
            this.szukany_wynik.BackColor = System.Drawing.SystemColors.Info;
            this.szukany_wynik.Location = new System.Drawing.Point(494, 151);
            this.szukany_wynik.Margin = new System.Windows.Forms.Padding(2);
            this.szukany_wynik.Name = "szukany_wynik";
            this.szukany_wynik.ReadOnly = true;
            this.szukany_wynik.Size = new System.Drawing.Size(68, 20);
            this.szukany_wynik.TabIndex = 4;
            // 
            // Szukaj
            // 
            this.Szukaj.Location = new System.Drawing.Point(494, 54);
            this.Szukaj.Margin = new System.Windows.Forms.Padding(2);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(55, 25);
            this.Szukaj.TabIndex = 5;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.Szukaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "wzór";
            // 
            // wzor
            // 
            this.wzor.Location = new System.Drawing.Point(11, 274);
            this.wzor.Name = "wzor";
            this.wzor.ReadOnly = true;
            this.wzor.Size = new System.Drawing.Size(600, 20);
            this.wzor.TabIndex = 7;
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 308);
            this.Controls.Add(this.wzor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.szukany_wynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.szukana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Wykres";
            this.Text = "Wykres";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox szukana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox szukany_wynik;
        private System.Windows.Forms.Button Szukaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wzor;
    }
}