using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDashboardMVC.ControlesUsuario
{
    public partial class UC_PantallaInicio : UserControl
    {
        public UC_PantallaInicio()
        {
            InitializeComponent();
        }

        public void setImagenMundo(string ruta)
        {
            ImagenMundo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenMundo.Image = Image.FromFile(ruta);
        }

    }
}
