
namespace ProyectoDashboardMVC.Formularios
{
    partial class PopUp
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
            this.TLP_PopUp = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Ayuda = new System.Windows.Forms.TextBox();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.TLP_PopUp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_PopUp
            // 
            this.TLP_PopUp.ColumnCount = 1;
            this.TLP_PopUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_PopUp.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TLP_PopUp.Controls.Add(this.TB_Ayuda, 0, 0);
            this.TLP_PopUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_PopUp.Location = new System.Drawing.Point(0, 0);
            this.TLP_PopUp.Name = "TLP_PopUp";
            this.TLP_PopUp.RowCount = 2;
            this.TLP_PopUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TLP_PopUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_PopUp.Size = new System.Drawing.Size(274, 156);
            this.TLP_PopUp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BT_Aceptar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_Ayuda
            // 
            this.TB_Ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Ayuda.Location = new System.Drawing.Point(3, 3);
            this.TB_Ayuda.Multiline = true;
            this.TB_Ayuda.Name = "TB_Ayuda";
            this.TB_Ayuda.Size = new System.Drawing.Size(268, 111);
            this.TB_Ayuda.TabIndex = 1;
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpString(this.BT_Aceptar, "Haz clic aquí para cerrar");
            this.BT_Aceptar.Location = new System.Drawing.Point(137, 3);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.helpProvider1.SetShowHelp(this.BT_Aceptar, true);
            this.BT_Aceptar.Size = new System.Drawing.Size(128, 27);
            this.BT_Aceptar.TabIndex = 0;
            this.BT_Aceptar.Text = "Cerrar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            this.BT_Aceptar.Click += new System.EventHandler(this.BT_Aceptar_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 156);
            this.Controls.Add(this.TLP_PopUp);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.PopUp_Load);
            this.TLP_PopUp.ResumeLayout(false);
            this.TLP_PopUp.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_PopUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.TextBox TB_Ayuda;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}