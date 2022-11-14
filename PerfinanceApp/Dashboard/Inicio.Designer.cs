namespace Dashboard
{
    partial class Inicio
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel5 = new System.Windows.Forms.Panel();
            this.graficInicio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficInicio)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.graficInicio);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(52, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(661, 259);
            this.panel5.TabIndex = 14;
            // 
            // graficInicio
            // 
            this.graficInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea2.AxisX.MajorTickMark.Size = 3F;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LabelStyle.Format = "${0}";
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea2.Name = "ChartArea1";
            this.graficInicio.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend2.ForeColor = System.Drawing.Color.Gainsboro;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.graficInicio.Legends.Add(legend2);
            this.graficInicio.Location = new System.Drawing.Point(1, 35);
            this.graficInicio.Name = "graficInicio";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.MediumPurple;
            series2.MarkerSize = 10;
            series2.Name = "Gastos";
            this.graficInicio.Series.Add(series2);
            this.graficInicio.Size = new System.Drawing.Size(659, 197);
            this.graficInicio.TabIndex = 0;
            this.graficInicio.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.ForeColor = System.Drawing.Color.Gainsboro;
            title2.Name = "Title1";
            this.graficInicio.Titles.Add(title2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(300, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ultimo Mes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(319, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gastos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(359, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 130);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dashboard.Properties.Resources.nominas;
            this.pictureBox3.Location = new System.Drawing.Point(28, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 40);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(86, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "+$1282";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(90, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ultimo Mes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(87, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nomina";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(52, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 130);
            this.panel6.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dashboard.Properties.Resources.ingbal;
            this.pictureBox2.Location = new System.Drawing.Point(28, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(86, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "$1982";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(25, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informacion de los ultimos 30 dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balance";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 513);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficInicio)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficInicio;
        private System.Windows.Forms.Label label12;
    }
}