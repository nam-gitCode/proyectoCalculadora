﻿
namespace proyectoCalculadora
{
    partial class frmGraficadora
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
            this.chrGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnCerrarGraf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // chrGrafica
            // 
            chartArea1.Name = "ChartArea1";
            this.chrGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrGrafica.Legends.Add(legend1);
            this.chrGrafica.Location = new System.Drawing.Point(12, 12);
            this.chrGrafica.Name = "chrGrafica";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            this.chrGrafica.Series.Add(series1);
            this.chrGrafica.Size = new System.Drawing.Size(300, 300);
            this.chrGrafica.TabIndex = 0;
            this.chrGrafica.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(x) = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(16, 345);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(296, 40);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarGraf
            // 
            this.btnCerrarGraf.Location = new System.Drawing.Point(16, 391);
            this.btnCerrarGraf.Name = "btnCerrarGraf";
            this.btnCerrarGraf.Size = new System.Drawing.Size(296, 40);
            this.btnCerrarGraf.TabIndex = 4;
            this.btnCerrarGraf.Text = "Cerrar";
            this.btnCerrarGraf.UseVisualStyleBackColor = true;
            this.btnCerrarGraf.Click += new System.EventHandler(this.btnCerrarGraf_Click);
            // 
            // frmGraficadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.btnCerrarGraf);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrGrafica);
            this.Name = "frmGraficadora";
            this.Text = "frmGraficadora";
            this.Load += new System.EventHandler(this.frmGraficadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnCerrarGraf;
    }
}