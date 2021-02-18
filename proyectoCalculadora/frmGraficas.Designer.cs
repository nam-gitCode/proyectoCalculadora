
namespace proyectoCalculadora
{
    partial class frmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraf1 = new System.Windows.Forms.Button();
            this.btnGraf2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "F1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "F2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Grafica";
            // 
            // btnGraf1
            // 
            this.btnGraf1.Location = new System.Drawing.Point(318, 23);
            this.btnGraf1.Name = "btnGraf1";
            this.btnGraf1.Size = new System.Drawing.Size(75, 23);
            this.btnGraf1.TabIndex = 1;
            this.btnGraf1.Text = "button1";
            this.btnGraf1.UseVisualStyleBackColor = true;
            this.btnGraf1.Click += new System.EventHandler(this.btnGraf1_Click);
            // 
            // btnGraf2
            // 
            this.btnGraf2.Location = new System.Drawing.Point(318, 52);
            this.btnGraf2.Name = "btnGraf2";
            this.btnGraf2.Size = new System.Drawing.Size(75, 23);
            this.btnGraf2.TabIndex = 2;
            this.btnGraf2.Text = "button2";
            this.btnGraf2.UseVisualStyleBackColor = true;
            // 
            // frmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraf2);
            this.Controls.Add(this.btnGraf1);
            this.Controls.Add(this.chart1);
            this.Name = "frmGraficas";
            this.Text = "frmGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGraf1;
        private System.Windows.Forms.Button btnGraf2;
    }
}