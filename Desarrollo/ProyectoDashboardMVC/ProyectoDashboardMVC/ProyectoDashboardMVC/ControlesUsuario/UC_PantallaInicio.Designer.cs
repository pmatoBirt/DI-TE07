
namespace ProyectoDashboardMVC.ControlesUsuario
{
    partial class UC_PantallaInicio
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
            this.ImagenMundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMundo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenMundo
            // 
            this.ImagenMundo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImagenMundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagenMundo.Location = new System.Drawing.Point(0, 0);
            this.ImagenMundo.Name = "ImagenMundo";
            this.ImagenMundo.Size = new System.Drawing.Size(1061, 663);
            this.ImagenMundo.TabIndex = 0;
            this.ImagenMundo.TabStop = false;
            // 
            // UC_GraficoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagenMundo);
            this.Name = "UC_GraficoEmpresa";
            this.Size = new System.Drawing.Size(1061, 663);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenMundo;
    }
}
