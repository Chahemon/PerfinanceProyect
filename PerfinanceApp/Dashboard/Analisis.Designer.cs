namespace Dashboard
{
    partial class Analisis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafic1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficpastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficpastel)).BeginInit();
            this.SuspendLayout();
            // 
            // grafic1
            // 
            this.grafic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.Name = "ChartArea1";
            this.grafic1.ChartAreas.Add(chartArea1);
            this.grafic1.DataSource = this.grafic1.Images;
            legend1.Name = "Legend1";
            this.grafic1.Legends.Add(legend1);
            this.grafic1.Location = new System.Drawing.Point(36, 12);
            this.grafic1.Name = "grafic1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafic1.Series.Add(series1);
            this.grafic1.Size = new System.Drawing.Size(679, 174);
            this.grafic1.TabIndex = 0;
            this.grafic1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Ingresos";
            this.grafic1.Titles.Add(title1);
            this.grafic1.UseWaitCursor = true;
            // 
            // graficpastel
            // 
            this.graficpastel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.graficpastel.BorderlineColor = System.Drawing.Color.Empty;
            this.graficpastel.CausesValidation = false;
            chartArea2.Name = "ChartArea1";
            this.graficpastel.ChartAreas.Add(chartArea2);
            this.graficpastel.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Name = "Legend1";
            this.graficpastel.Legends.Add(legend2);
            this.graficpastel.Location = new System.Drawing.Point(241, 192);
            this.graficpastel.Name = "graficpastel";
            this.graficpastel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.graficpastel.Series.Add(series2);
            this.graficpastel.Size = new System.Drawing.Size(300, 300);
            this.graficpastel.TabIndex = 1;
            this.graficpastel.Text = "chart1";
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 513);
            this.Controls.Add(this.graficpastel);
            this.Controls.Add(this.grafic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analisis";
            this.Text = "Analisis";
            this.Load += new System.EventHandler(this.Analisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficpastel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafic1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficpastel;
    }
}