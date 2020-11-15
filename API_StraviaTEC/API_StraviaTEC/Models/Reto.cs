using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Reto
    {
        String nombre { get; set; }
        String privacidad { get; set; }
        List<String> patrocinadores { get; set; }
        String tipo_actividad { get; set; }
        String tipo_reto { get; set; }
        String periodo { get; set; }
        String fecha_inicio { get; set; }
        String fecha_final { get; set; }
        String objetivo { get; set; }
        String id_organizador { get; set; }
        String id_deportista { get; set; }

        public Reto(string nombre, string privacidad, List<string> patrocinadores, string tipo_actividad, string tipo_reto, string periodo, string fecha_inicio, string fecha_final, string objetivo, string id_organizador, string id_deportista)
        {
            this.nombre = nombre;
            this.privacidad = privacidad;
            this.patrocinadores = patrocinadores;
            this.tipo_actividad = tipo_actividad;
            this.tipo_reto = tipo_reto;
            this.periodo = periodo;
            this.fecha_inicio = fecha_inicio;
            this.fecha_final = fecha_final;
            this.objetivo = objetivo;
            this.id_organizador = id_organizador;
            this.id_deportista = id_deportista;
        }
        public Reto()
        {
        }
    }
}