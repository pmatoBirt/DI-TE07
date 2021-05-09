using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesDashboard;

namespace ProyectoDashboardMVC.ControlesUsuario
{
    public partial class UC_DatosIdentificativos : UserControl
    {

        public UC_DatosIdentificativos()
        {
            InitializeComponent();
        }

        public void EscribirInformacion(Comercial c)
        {
            LB_Nombre.Text = c.Nombre;
            LB_Apellidos.Text = c.Apellido;
            LB_Ciudad.Text = c.Localidad;
            LB_Edad.Text = c.Edad.ToString(); 
        }
    }
}
