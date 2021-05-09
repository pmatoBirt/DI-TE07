using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesDashboard;
using System.IO; 

namespace ProyectoDashboardDAL
{
    public static class AccesoADatos
    {
        //private static string rutaComerciales = "..\\..\\..\\ProyectoDashboardDAL\\BD\\1_datos_comerciales.csv";
        //private static string rutaFacturacion = "..\\..\\..\\ProyectoDashboardDAL\\BD\\2_facturacion_comercial.csv"; 

        private static string rutaComerciales = "BD\\1_datos_comerciales.csv";
        private static string rutaFacturacion = "BD\\2_facturacion_comercial.csv"; 

        public static Comercial[] CargarDatosComerciales(out string[] cabecera)
        {
            int numeroComerciales = 0;
            string line;
            List<Comercial> listaComerciales = null;

            try
            {
                listaComerciales = new List<Comercial>();
                StreamReader fileReader = new System.IO.StreamReader(rutaComerciales);
                line = fileReader.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(',');
                    cabecera = new string[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        cabecera[i] = words[i].Trim();
                    }
                }
                else
                {
                    fileReader.Close();
                    cabecera = null;
                    return null;
                }
                line = fileReader.ReadLine();
                while (line != null)
                {
                    if (line != "")
                    {
                        string[] words = line.Split(',');
                        listaComerciales.Add(new Comercial(int.Parse(words[0].Trim()), words[1].Trim(), words[2].Trim(), words[3].Trim(), int.Parse(words[4].Trim())));
                        numeroComerciales++;
                    }
                    line = fileReader.ReadLine();
                }
                fileReader.Close();
                return listaComerciales.ToArray();
            }
            catch (Exception e)
            {
                cabecera = null; 
                return null; 
            }
        }

        public static int[][] CargarDatosFacturacion(out string[] cabecera)
        {
            int numeroFilas = 0;
            int numeroCampos = 0; 
            string line;
            List<int[]> listaFacturacion = null;
            int[][] resultado = null; 

            try
            {
                listaFacturacion = new List<int[]>();
                StreamReader fileReader = new System.IO.StreamReader(rutaFacturacion);
                line = fileReader.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(',');
                    numeroCampos = words.Length; 
                    cabecera = new string[numeroCampos];
                    for (int i = 0; i < numeroCampos; i++)
                    {
                        cabecera[i] = words[i].Trim();
                    }
                }
                else
                {
                    fileReader.Close();
                    cabecera = null;
                    return null;
                }
                line = fileReader.ReadLine();
                while (line != null)
                {
                    if (line != "")
                    { 
                        string[] words = line.Split(',');
                        int[] registro = new int[numeroCampos];
                        for (int i = 0; i < numeroCampos; i++)
                        {
                            registro[i] = int.Parse(words[i].Trim());
                        }
                        listaFacturacion.Add(registro);
                        numeroFilas++;
                    }
                    line = fileReader.ReadLine();
                }
                fileReader.Close();

                int indice = 0; 
                resultado = new int[numeroFilas][];
                foreach (int[] e in listaFacturacion)
                {
                    resultado[indice] = new int[numeroCampos];
                    for (int j = 0; j < numeroCampos; j++) resultado[indice][j] = e[j];
                    indice++; 
                }

                return resultado; 
            }
            catch (Exception e)
            {
                cabecera = null;
                return null;
            }
        }

    }
}
