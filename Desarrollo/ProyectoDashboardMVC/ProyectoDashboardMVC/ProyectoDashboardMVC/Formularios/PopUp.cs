using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDashboardMVC.Formularios
{
    public partial class PopUp : Form
    {
        public PopUp(string texto)
        {
            InitializeComponent();
            this.TB_Ayuda.Text = texto; 
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
