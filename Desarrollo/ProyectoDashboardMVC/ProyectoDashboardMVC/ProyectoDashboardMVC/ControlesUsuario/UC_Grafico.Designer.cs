
namespace ProyectoDashboardMVC.ControlesUsuario
{
    partial class UC_Grafico
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.CHART_Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // CHART_Grafico
            // 
            this.CHART_Grafico.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.CHART_Grafico.ChartAreas.Add(chartArea1);
            this.CHART_Grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.CHART_Grafico.Legends.Add(legend1);
            this.CHART_Grafico.Location = new System.Drawing.Point(0, 0);
            this.CHART_Grafico.Name = "CHART_Grafico";
            this.CHART_Grafico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CHART_Grafico.Size = new System.Drawing.Size(1058, 671);
            this.CHART_Grafico.TabIndex = 0;
            // 
            // UC_Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CHART_Grafico);
            this.Name = "UC_Grafico";
            this.Size = new System.Drawing.Size(1058, 671);
            ((System.ComponentModel.ISupportInitialize)(this.CHART_Grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CHART_Grafico;
    }
}
