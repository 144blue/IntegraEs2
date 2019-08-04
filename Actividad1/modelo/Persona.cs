using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Persona
    {


        private String Nombre;
        private String Cedula;
        private String Placa;
        private String Codigo;

        public Persona(string nombre, string cedula, string placa, string codigo)
        {
            Nombre1 = nombre;
            Cedula1 = cedula;
            Placa1 = placa;
            Codigo1 = codigo;
           
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
    }
}
