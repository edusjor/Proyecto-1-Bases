using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Amigos_Atletas
    {
        String nombre { get; set; }
        String direccion { get; set; }
        String follow { get; set; }
        String actividad { get; set; }
        String id_deportista { get; set; }
        public Amigos_Atletas(string nombre, string direccion, string follow, string actividad, string id_deportista)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.follow = follow;
            this.actividad = actividad;
            this.id_deportista = id_deportista;
        }
        public Amigos_Atletas()
        {
        }
    }
}