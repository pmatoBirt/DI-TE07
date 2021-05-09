using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDashboardBLL;
using ProyectoDashboardMVC.ControlesUsuario;
using UtilidadesDashboard;

namespace ProyectoDashboardMVC.Formularios
{
    public partial class ProyectoDashboardMVC : Form
    {
        //private static string rutaLogo = "..\\..\\..\\Recursos\\LogoEmpresa.png";
        //private static string rutaMundo = "..\\..\\..\\Recursos\\MapaMundi.png";
        //private static string rutaAyuda = "..\\..\\..\\REcursos\\Manual\\Manual.chm";

        private static string rutaLogo = "Recursos\\LogoEmpresa.png";
        private static string rutaMundo = "Recursos\\MapaMundi.png";
        private static string rutaAyuda = "REcursos\\Manual\\Manual.chm";

        private TableLayoutPanel tlp_base;
        private TableLayoutPanel tlp_grafico;

        //Representa el control que actualmente se esta visualizando. 
        private UserControl cu_actual;

        private int comercialSeleccionado;
        private int opcionSeleccionada;

        public ProyectoDashboardMVC()
        {
            InitializeComponent();
            tlp_base = TLP_Base;
            tlp_grafico = TLP_Graficos;
            Inicializar();
            AniadirAyuda(); 
        }

        private void Inicializar()
        {
            comercialSeleccionado = 0;
            opcionSeleccionada = 0;
            BT_DatosIdentificativos.Enabled = false;

            string resultado = "";
            if (DashboardBLL.Inicializar(out resultado))
            {
                BT_Comercial1.Enabled = true;
                BT_Comercial2.Enabled = true;
                BT_Comercial3.Enabled = true;
                BT_Todos.Enabled = true;
                BT_FacturacionEmpresas.Enabled = true;
                BT_FacturacionTotal.Enabled = true; 
            }
            else
            {
                BT_Comercial1.Enabled = false;
                BT_Comercial2.Enabled = false;
                BT_Comercial3.Enabled = false;
                BT_Todos.Enabled = false; 
                BT_FacturacionEmpresas.Enabled = false;
                BT_FacturacionTotal.Enabled = false;
            }

            LB_Grafico.Text = resultado;

            //Dibuajamos el Logo de la Empresa
            this.LogoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            this.LogoEmpresa.Image = Image.FromFile(rutaLogo);

            //Añadimos la imagen incial
            UC_PantallaInicio cu_inicial = new ControlesUsuario.UC_PantallaInicio();
            cu_inicial.setImagenMundo(rutaMundo);
            tlp_grafico.Controls.Add(cu_inicial, 0, 1);
            cu_actual = cu_inicial;
        }

        private void AniadirAyuda()
        {
            ttMensaje.SetToolTip(this.LogoEmpresa, "Haz clic aqui para recargar la información");

            ttMensaje.SetToolTip(this.BT_Comercial1, "Haz clic aqui para ver la información del Comercial 1");
            ttMensaje.SetToolTip(this.BT_Comercial2, "Haz clic aqui para ver la información del Comercial 2");
            ttMensaje.SetToolTip(this.BT_Comercial3, "Haz clic aqui para ver la información del Comercial 3");

            ttMensaje.SetToolTip(this.BT_Todos, "Haz clic aqui para ver la información de todos los Comerciales");

            ttMensaje.SetToolTip(this.BT_DatosIdentificativos, "Haz clic aqui para ver los Datos Identificativos");
            ttMensaje.SetToolTip(this.BT_FacturacionEmpresas, "Haz clic aqui para ver la Facturación a Empresas");
            ttMensaje.SetToolTip(this.BT_FacturacionTotal, "Haz clic aqui para ver la Facturación Total");

            ttMensaje.SetToolTip(this.BT_Ayuda, "Haz clic aquí para ver la ayuda"); 
        }

        private void ResetearControles()
        {
            tlp_grafico.Controls.Remove(cu_actual);
            Inicializar(); 
        }

        private void EscribirTexto()
        {
            string textoOpcion = "";
            if (comercialSeleccionado == 0)
            {
                switch (opcionSeleccionada)
                {
                    case 1: { textoOpcion = "Facturacion Total a Empresas"; break; }
                    case 2: { textoOpcion = "Facturacion Total"; break; }
                    default: { textoOpcion = "Facturacion Total por Comercial"; break; }
                }
                LB_Grafico.Text = textoOpcion; 
            }
            else
            {
                string textoComercial = "";
                Comercial c = null;
                DashboardBLL.GetComercial(comercialSeleccionado, out c);
                textoComercial = string.Format("Comercial {0}: {1}, {2}", comercialSeleccionado, c.Apellido, c.Nombre);

                switch (opcionSeleccionada)
                {
                    case 1: { textoOpcion = "Facturacion a Empresas"; break; }
                    case 2: { textoOpcion = "Facturacion Total"; break; }
                    default: { textoOpcion = "Datos Identificativos"; break; }
                }

                LB_Grafico.Text = string.Format("{0}; {1};", textoComercial, textoOpcion);
            }
        }

        private void DibujarGrafico()
        {
            if (comercialSeleccionado == 0)
            {
                switch (opcionSeleccionada)
                {
                    case 1:
                        {
                            //Mostramos la Facturación a cada Empresa de todos los Comerciales juntos
                            UC_Grafico uc = MostrarGrafico();
                            if (!uc.MostrarFacturacionTotalPorEmpresa()) ResetearControles();
                            break;
                        }
                    case 2:
                        {
                            //Mostramos la Facturacion Total de todos los Comerciales juntos
                            UC_Grafico uc = MostrarGrafico();
                            if (!uc.MostrarFacturacionTotal()) ResetearControles();
                            break;
                        }
                    default:
                        {
                            //Motramos las distintas facturaciones a cada Empresa separando los Comerciales. 
                            UC_Grafico uc = MostrarGrafico();
                            if (!uc.MostrarFacturacionTotalPorComercial()) ResetearControles();
                            break;
                        }
                }
            }
            else
            {
                switch (opcionSeleccionada)
                {
                    case 1:
                        {
                            //Mostramos la Facturación a cada Empresa de un solo Comercial
                            UC_Grafico uc = MostrarGrafico();
                            if (!uc.MostrarFacturacionComercialPorEmpresa(comercialSeleccionado)) ResetearControles();
                            break;
                        }
                    case 2:
                        {
                            //Mostramos la Facturacion Total de un solo Comercial
                            UC_Grafico uc = MostrarGrafico();
                            if (!uc.MostrarFacturacionTotalDeComercial(comercialSeleccionado)) ResetearControles();
                            break;
                        }
                    default:
                        {
                            MostrarDatosIdentificativos(comercialSeleccionado);
                            break;
                        }
                }
            }
        }

        private UC_Grafico MostrarGrafico()
        {
            tlp_grafico.Controls.Remove(cu_actual);
            UC_Grafico cu_grafico = new ControlesUsuario.UC_Grafico();
            tlp_grafico.Controls.Add(cu_grafico, 0, 1);
            cu_actual = cu_grafico;
            return cu_grafico; 
        }

        private void MostrarDatosIdentificativos(int numeroComercial)
        {
            tlp_grafico.Controls.Remove(cu_actual);
            Comercial c = null;
            if (ProyectoDashboardBLL.DashboardBLL.GetComercial(numeroComercial, out c))
            {
                tlp_grafico.Controls.Remove(cu_actual);
                UC_DatosIdentificativos cu_datosIdentificativos = new ControlesUsuario.UC_DatosIdentificativos();
                cu_datosIdentificativos.EscribirInformacion(c);
                tlp_grafico.Controls.Add(cu_datosIdentificativos, 0, 1);
                cu_actual = cu_datosIdentificativos;
            }
            else 
            {
                //Si hay algun problema, reseteamos el Interfaz Gráfico...
                ResetearControles(); 
            }

        }

        private void LogoEmpresa_Click(object sender, EventArgs e)
        {
            ResetearControles();
        }

        private void BT_Comercial1_Click(object sender, EventArgs e)
        {
            comercialSeleccionado = 1;
            BT_DatosIdentificativos.Enabled = true;
            EscribirTexto();
            DibujarGrafico();
        }

        private void BT_Comercial2_Click(object sender, EventArgs e)
        {
            comercialSeleccionado = 2;
            BT_DatosIdentificativos.Enabled = true;
            EscribirTexto();
            DibujarGrafico();
        }

        private void BT_Comercial3_Click(object sender, EventArgs e)
        {
            comercialSeleccionado = 3;
            BT_DatosIdentificativos.Enabled = true;
            EscribirTexto();
            DibujarGrafico();
        }

        private void BT_Todos_Click(object sender, EventArgs e)
        {
            opcionSeleccionada = 0; 
            comercialSeleccionado = 0;
            BT_DatosIdentificativos.Enabled = false;
            EscribirTexto();
            DibujarGrafico(); 
        }

        private void BT_DatosIdentificativos_Click(object sender, EventArgs e)
        {
            opcionSeleccionada = 0;
            EscribirTexto();
            MostrarDatosIdentificativos(comercialSeleccionado);
        }

        private void BT_FacturacionEmpresas_Click(object sender, EventArgs e)
        {
            opcionSeleccionada = 1;
            EscribirTexto();
            DibujarGrafico(); 
        }

        private void BT_FacturacionTotal_Click(object sender, EventArgs e)
        {
            opcionSeleccionada = 2;
            EscribirTexto();
            DibujarGrafico();
        }

        private void ProyectoDashboardMVC_Load(object sender, EventArgs e)
        {

        }

        private void TLP_Graficos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_Ayuda_Click(object sender, EventArgs e)
        {
            string texto = "Los botones de la parte superior permiten escoger a los comerciales" + System.Environment.NewLine +
                "Los botones de la parte izquierda permiten escoger el tipo de información a visualizar" + System.Environment.NewLine +
                "El logo de la empresa permite recargar la información"; 
            PopUp pop = new PopUp(texto);
            pop.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, rutaAyuda); 
        }
    }
}
