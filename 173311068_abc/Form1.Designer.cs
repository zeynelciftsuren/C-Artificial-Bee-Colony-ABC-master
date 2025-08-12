namespace _173311068_abc
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nudKoloni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAlt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudUst = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCevrim = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDeneme = new System.Windows.Forms.NumericUpDown();
            this.chartEniyi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            this.SuspendLayout();
            // 
            // nudKoloni
            // 
            this.nudKoloni.Location = new System.Drawing.Point(178, 27);
            this.nudKoloni.Margin = new System.Windows.Forms.Padding(6);
            this.nudKoloni.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKoloni.Name = "nudKoloni";
            this.nudKoloni.Size = new System.Drawing.Size(220, 29);
            this.nudKoloni.TabIndex = 0;
            this.nudKoloni.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koloni Boyutu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alt Sınır";
            // 
            // nudAlt
            // 
            this.nudAlt.Location = new System.Drawing.Point(178, 78);
            this.nudAlt.Margin = new System.Windows.Forms.Padding(6);
            this.nudAlt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAlt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudAlt.Name = "nudAlt";
            this.nudAlt.Size = new System.Drawing.Size(220, 29);
            this.nudAlt.TabIndex = 6;
            this.nudAlt.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üst Sınır";
            // 
            // nudUst
            // 
            this.nudUst.Location = new System.Drawing.Point(178, 119);
            this.nudUst.Margin = new System.Windows.Forms.Padding(6);
            this.nudUst.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUst.Name = "nudUst";
            this.nudUst.Size = new System.Drawing.Size(220, 29);
            this.nudUst.TabIndex = 8;
            this.nudUst.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(224, 243);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(109, 46);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Çevrim Sayısı";
            // 
            // nudCevrim
            // 
            this.nudCevrim.Location = new System.Drawing.Point(178, 185);
            this.nudCevrim.Margin = new System.Windows.Forms.Padding(6);
            this.nudCevrim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCevrim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCevrim.Name = "nudCevrim";
            this.nudCevrim.Size = new System.Drawing.Size(220, 29);
            this.nudCevrim.TabIndex = 11;
            this.nudCevrim.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deneme Sayısı";
            // 
            // nudDeneme
            // 
            this.nudDeneme.Location = new System.Drawing.Point(178, 152);
            this.nudDeneme.Margin = new System.Windows.Forms.Padding(6);
            this.nudDeneme.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDeneme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeneme.Name = "nudDeneme";
            this.nudDeneme.Size = new System.Drawing.Size(220, 29);
            this.nudDeneme.TabIndex = 13;
            this.nudDeneme.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // chartEniyi
            // 
            chartArea7.Name = "ChartArea1";
            this.chartEniyi.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartEniyi.Legends.Add(legend7);
            this.chartEniyi.Location = new System.Drawing.Point(630, 326);
            this.chartEniyi.Name = "chartEniyi";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "x1";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "x2";
            this.chartEniyi.Series.Add(series10);
            this.chartEniyi.Series.Add(series11);
            this.chartEniyi.Size = new System.Drawing.Size(461, 307);
            this.chartEniyi.TabIndex = 15;
            this.chartEniyi.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(670, 241);
            this.textBox1.TabIndex = 16;
            // 
            // chartFx
            // 
            chartArea8.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartFx.Legends.Add(legend8);
            this.chartFx.Location = new System.Drawing.Point(34, 326);
            this.chartFx.Name = "chartFx";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "fx";
            this.chartFx.Series.Add(series12);
            this.chartFx.Size = new System.Drawing.Size(461, 307);
            this.chartFx.TabIndex = 17;
            this.chartFx.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "X1 - X2 - Fx - Fit Değerleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fx Grafiği";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(808, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "X1 ve X2 Grafiği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 645);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartFx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartEniyi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDeneme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCevrim);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudUst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudKoloni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Yapay Arı Kolonisi - Ali Eray KISABACAK -173311068";
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudKoloni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudUst;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCevrim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDeneme;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEniyi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

