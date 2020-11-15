using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Cliente
    {
        public String usuario { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String contrasena { get; set; }
        public String nacionalidad { get; set; }
        public String foto { get; set; }
        public int edad { get; set; }

        public Cliente(string usuario, string nombre, string apellidos, string contrasena, string nacionalidad, string foto, int edad)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contrasena = contrasena;
            this.nacionalidad = nacionalidad;
            this.foto = foto;
            this.edad = edad;
        }

        public Cliente()
        {

        }
    }
}