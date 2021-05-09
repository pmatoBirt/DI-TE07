using System;

namespace UtilidadesDashboard
{
    public class Comercial
    {
        private int numero_comercial;
        private string nombre;
        private string apellido;
        private string localidad;
        private int edad;

        public Comercial(int numero_comercial, string nombre, string apellido, string localidad, int edad)
        {
            this.numero_comercial = numero_comercial;
            this.nombre = nombre;
            this.apellido = apellido;
            this.localidad = localidad;
            this.edad = edad;
        }

        public int Numero_comercial { get => numero_comercial; set => numero_comercial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }
    }

}


