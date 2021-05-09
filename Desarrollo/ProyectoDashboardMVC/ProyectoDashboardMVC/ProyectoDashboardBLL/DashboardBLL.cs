using ProyectoDashboardDAL;
using System;
using UtilidadesDashboard;

namespace ProyectoDashboardBLL
{
    public static class DashboardBLL
    {
        static DashboardBLL()
        {

        }

        public static bool Inicializar(out String textoBienvenida)
        {
            bool resultado = GestionDatos.CargarDatos();
            if (resultado) textoBienvenida = "Dashboard de Pablo Mato Rilo. Seleccione las estadísticas que desee... ";
            else textoBienvenida = "Error en el acceso a los datos. No se ha podido recuperar la información. ";
            return resultado; 
        }

        public static bool GetCabeceraComercial(out string[] cabeceraComercial)
        {
            string[] resultado;
            resultado = GestionDatos.GetCabeceraComercial();
            if (resultado != null)
            {
                cabeceraComercial = resultado;
                return true;
            }
            else 
            {
                cabeceraComercial = null; 
                return false; 
            }
        }

        public static bool GetCabeceraFacturacion(out string[] cabeceraFacturacion)
        {
            string[] resultado;
            resultado = GestionDatos.GetCabeceraFacturacion();
            if (resultado != null)
            {
                cabeceraFacturacion = resultado;
                return true;
            }
            else
            {
                cabeceraFacturacion = null;
                return false;
            }
        }

        public static bool GetMeses(out string[] meses)
        {
            string[] resultado;
            resultado = GestionDatos.GetMeses();
            if (resultado != null)
            {
                meses = resultado;
                return true;
            }
            else
            {
                meses = null;
                return false;
            }
        }

        public static bool GetComercial(int numeroComercial, out Comercial comercial)
        {
            Comercial resultado;
            resultado = GestionDatos.GetComercial(numeroComercial);
            if (resultado != null)
            {
                comercial = resultado;
                return true;
            }
            else
            {
                comercial = null;
                return false;
            }
        }

        public static bool GetFacturacionComercialPorEmpresa(int numeroComercial, int numeroEmpresa, out int[] facturacion)
        {
            int[] resultado;
            resultado = GestionDatos.GetFacturacionComercialPorEmpresa(numeroComercial, numeroEmpresa);
            if (resultado != null)
            {
                facturacion = resultado;
                return true;
            }
            else
            {
                facturacion = null;
                return false;
            }
        }

        public static bool GetFacturacionTotalComercial(int numeroComercial, out int[] facturacion)
        {
            int[] resultado;
            resultado = GestionDatos.GetFacturacionTotalComercial(numeroComercial);
            if (resultado != null)
            {
                facturacion = resultado;
                return true;
            }
            else
            {
                facturacion = null;
                return false;
            }
        }

        public static bool GetFacturacionTotalEmpresa(int numeroEmpresa, out int[] facturacion)
        {
            int[] resultado;
            resultado = GestionDatos.GetFacturacionTotalEmpresa(numeroEmpresa);
            if (resultado != null)
            {
                facturacion = resultado;
                return true;
            }
            else
            {
                facturacion = null;
                return false;
            }
        }

        public static bool GetFacturacionTotal(out int[] facturacion)
        {
            int[] resultado;
            resultado = GestionDatos.GetFacturacionTotal();
            if (resultado != null)
            {
                facturacion = resultado;
                return true;
            }
            else
            {
                facturacion = null;
                return false;
            }
        }
    }
}
