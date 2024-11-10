using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyecto
{
    public class Cliente
    {
        public Cliente(string nombre, string correo, string teléfono) 
        {
            Nombre = nombre;
            Correo = correo;
            Teléfono = teléfono;
        }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Teléfono { get; set; }
    }
}
