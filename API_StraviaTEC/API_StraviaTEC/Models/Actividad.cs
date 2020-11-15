using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Actividad
    {
        String duracion { get; set; }
        String tipo { get; set; }
        String fecha { get; set; }
        int kilometraje { get; set; }
        String recorrido { get; set; }
        String hora { get; set; }
        String id_deportista { get; set; }
        public Actividad(string duracion, string tipo, string fecha, int kilometraje, string recorrido, string hora, string id_deportista)
        {
            this.duracion = duracion;
            this.tipo = tipo;
            this.fecha = fecha;
            this.kilometraje = kilometraje;
            this.recorrido = recorrido;
            this.hora = hora;
            this.id_deportista = id_deportista;
        }

        public Actividad()
        {
        }
    }
}