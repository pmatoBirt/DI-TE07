using System;
using UtilidadesDashboard;

namespace ProyectoDashboardDAL
{
    public static class GestionDatos
    {
        //Cabecera de los datos a mostrar
        static private string[] cabeceraComerciales = null;

        //Datos de Comerciales
        static private Comercial[] comerciales = null;

        //Cabecera de los datos a mostrar
        static private string[] cabeceraFacturacion = null;

        //Datos de facturacion
        static private int[][] facturacion = null;

        static GestionDatos()
        {

        }

        public static bool CargarDatos()
        {
            comerciales = null;
            facturacion = null;

            comerciales = AccesoADatos.CargarDatosComerciales(out cabeceraComerciales);
            facturacion = AccesoADatos.CargarDatosFacturacion(out cabeceraFacturacion);

            if (comerciales == null || facturacion == null) return false;
            else return true;
        }

        public static string[] GetCabeceraComercial()
        {
            return cabeceraComerciales; 
        }

        public static string[] GetCabeceraFacturacion()
        {
            return cabeceraFacturacion;
        }

        public static string[] GetMeses()
        {
            string[] resultado;
            resultado = new string[12];
            for (int i = 0; i < resultado.Length; i++) resultado[i] = cabeceraFacturacion[i + 2];
            return resultado; 
        }

        public static Comercial GetComercial(int numeroComercial)
        {
            for (int i = 0; i < comerciales.Length; i++)
            {
                if (comerciales[i].Numero_comercial == numeroComercial) return (comerciales[i]); 
            }
            return null; 
        }

        public static int[] GetFacturacionComercialPorEmpresa(int numeroComercial, int numeroEmpresa)
        {
            int[] resultado = null; 
            for (int i = 0; i < facturacion.Length; i++)
            {
                if (facturacion[i][0] == numeroComercial) 
                {
                    if (facturacion[i][1] == numeroEmpresa)
                    {
                        resultado = new int[facturacion[i].Length - 2];
                        for (int j = 0; j < resultado.Length; j++) resultado[j] = facturacion[i][j + 2]; 
                    }
                }
            }
            return resultado; 
        }

        public static int[] GetFacturacionTotalComercial(int numeroComercial)
        {
            int[] resultado = null;
            bool primeraVez = true; 
            for (int i = 0; i < facturacion.Length; i++)
            {
                if (facturacion[i][0] == numeroComercial)
                {
                    if (primeraVez)
                    {
                        resultado = new int[facturacion[i].Length - 2];
                        for (int j = 0; j < resultado.Length; j++) resultado[j] = 0;
                        primeraVez = false; 
                    }
                    for (int j = 0; j < resultado.Length; j++) resultado[j] = resultado[j] + facturacion[i][j + 2];
                }
            }
            return resultado;
        }

        public static int[] GetFacturacionTotalEmpresa(int numeroEmpresa)
        {
            int[] resultado = null;
            bool primeraVez = true;
            for (int i = 0; i < facturacion.Length; i++)
            {
                if (facturacion[i][1] == numeroEmpresa)
                {
                    if (primeraVez)
                    {
                        resultado = new int[facturacion[i].Length - 2];
                        for (int j = 0; j < resultado.Length; j++) resultado[j] = 0;
                        primeraVez = false;
                    }
                    for (int j = 0; j < resultado.Length; j++) resultado[j] = resultado[j] + facturacion[i][j + 2];
                }
            }
            return resultado;
        }

        public static int[] GetFacturacionTotal()
        {
            int[] resultado = null;
            bool primeraVez = true;
            for (int i = 0; i < facturacion.Length; i++)
            {
                if (primeraVez)
                {
                    resultado = new int[facturacion[i].Length - 2];
                    for (int j = 0; j < resultado.Length; j++) resultado[j] = 0;
                    primeraVez = false;
                }
                for (int j = 0; j < resultado.Length; j++) resultado[j] = resultado[j] + facturacion[i][j + 2];
            }
            return resultado;
        }
    }
}
