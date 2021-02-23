
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnCerrarGraf = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // chrGrafica
            // 
            chartArea6.Name = "ChartArea1";
            this.chrGrafica.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrGrafica.Legends.Add(legend6);
            this.chrGrafica.Location = new System.Drawing.Point(12, 12);
            this.chrGrafica.Name = "chrGrafica";
            series6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "f(x)";
            this.chrGrafica.Series.Add(series6);
            this.chrGrafica.Size = new System.Drawing.Size(300, 300);
            this.chrGrafica.TabIndex = 0;
            this.chrGrafica.Text = "grafica";
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
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(45, 319);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(267, 20);
            this.txtFuncion.TabIndex = 2;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(16, 345);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(296, 40);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnCerrarGraf
            // 
            this.btnCerrarGraf.Location = new System.Drawing.Point(12, 437);
            this.btnCerrarGraf.Name = "btnCerrarGraf";
            this.btnCerrarGraf.Size = new System.Drawing.Size(296, 40);
            this.btnCerrarGraf.TabIndex = 4;
            this.btnCerrarGraf.Text = "Cerrar";
            this.btnCerrarGraf.UseVisualStyleBackColor = true;
            this.btnCerrarGraf.Click += new System.EventHandler(this.btnCerrarGraf_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 391);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(296, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Grafica";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(317, 14);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(24, 23);
            this.btnPotencia.TabIndex = 6;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(318, 43);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(24, 23);
            this.btnPi.TabIndex = 7;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(318, 72);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(24, 23);
            this.btnRaiz.TabIndex = 8;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // frmGraficadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 484);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrarGraf);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrGrafica);
            this.Name = "frmGraficadora";
            this.Text = "Graficadora";
            this.Load += new System.EventHandler(this.frmGraficadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnCerrarGraf;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnRaiz;
    }
}