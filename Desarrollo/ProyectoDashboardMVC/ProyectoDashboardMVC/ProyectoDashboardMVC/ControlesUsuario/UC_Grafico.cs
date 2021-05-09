using ProyectoDashboardBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UtilidadesDashboard;

namespace ProyectoDashboardMVC.ControlesUsuario
{
    public partial class UC_Grafico : UserControl
    {

        public UC_Grafico()
        {
            InitializeComponent();
        }

        public bool MostrarFacturacionTotalPorEmpresa()
        {
            string[] meses = null;
            int[] facturacion1 = null;
            int[] facturacion2 = null;
            if (DashboardBLL.GetMeses(out meses) && DashboardBLL.GetFacturacionTotalEmpresa(1, out facturacion1) && DashboardBLL.GetFacturacionTotalEmpresa(2, out facturacion2))
            {
                Series serie1 = CHART_Grafico.Series.Add("Empresa 1");
                Series serie2 = CHART_Grafico.Series.Add("Empresa 2");
                for (int i = 0; i < meses.Length; i++)
                {
                    serie1.Points.AddXY(meses[i], facturacion1[i]);
                    serie2.Points.AddXY(meses[i], facturacion2[i]);
                }
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool MostrarFacturacionTotal()
        {
            string[] meses = null;
            int[] facturacion = null;
            if (DashboardBLL.GetMeses(out meses) && DashboardBLL.GetFacturacionTotal(out facturacion))
            {
                Series serie = CHART_Grafico.Series.Add("Total");
                for (int i = 0; i < meses.Length; i++) serie.Points.AddXY(meses[i], facturacion[i]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MostrarFacturacionComercialPorEmpresa(int numeroComercial)
        {
            string[] meses = null;
            int[] facturacion1 = null;
            int[] facturacion2 = null;
            if (DashboardBLL.GetMeses(out meses) && DashboardBLL.GetFacturacionComercialPorEmpresa(numeroComercial, 1, out facturacion1) && DashboardBLL.GetFacturacionComercialPorEmpresa(numeroComercial, 2, out facturacion2))
            {
                Series serie1 = CHART_Grafico.Series.Add("Empresa 1");
                Series serie2 = CHART_Grafico.Series.Add("Empresa 2");
                for (int i = 0; i < meses.Length; i++)
                {
                    serie1.Points.AddXY(meses[i], facturacion1[i]);
                    serie2.Points.AddXY(meses[i], facturacion2[i]);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MostrarFacturacionTotalDeComercial(int numeroComercial)
        {
            string[] meses = null;
            int[] facturacion = null;

            Comercial c = null;
            if (DashboardBLL.GetMeses(out meses) && DashboardBLL.GetComercial(numeroComercial, out c) && DashboardBLL.GetFacturacionTotalComercial(numeroComercial, out facturacion))
            {
                Series serie = CHART_Grafico.Series.Add(string.Format("Total Comercial {0} - {1}", numeroComercial, c.Nombre));
                for (int i = 0; i < meses.Length; i++) serie.Points.AddXY(meses[i], facturacion[i]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MostrarFacturacionTotalPorComercial()
        {
            string[] meses = null;
            int[] facturacionComercial1 = null;
            int[] facturacionComercial2 = null;
            int[] facturacionComercial3 = null;

            Comercial c1 = null;
            Comercial c2 = null;
            Comercial c3 = null;
            if (DashboardBLL.GetComercial(1, out c1) && DashboardBLL.GetComercial(2, out c2) && DashboardBLL.GetComercial(3, out c3))
            {
                Series serie1 = CHART_Grafico.Series.Add(string.Format("1 - {0}", c1.Nombre));
                Series serie2 = CHART_Grafico.Series.Add(string.Format("2 - {0}", c2.Nombre));
                Series serie3 = CHART_Grafico.Series.Add(string.Format("3 - {0}", c3.Nombre));
                if (DashboardBLL.GetMeses(out meses) && DashboardBLL.GetFacturacionTotalComercial(1, out facturacionComercial1) && DashboardBLL.GetFacturacionTotalComercial(2, out facturacionComercial2) && DashboardBLL.GetFacturacionTotalComercial(3, out facturacionComercial3))
                {
                    for (int i = 0; i < meses.Length; i++)
                    {
                        serie1.Points.AddXY(meses[i], facturacionComercial1[i]);
                        serie2.Points.AddXY(meses[i], facturacionComercial2[i]);
                        serie3.Points.AddXY(meses[i], facturacionComercial3[i]);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                return false; 
            } 
        }
    }
}
