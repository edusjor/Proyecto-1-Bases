using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Grupo
    {
        String nombre_grupo { get; set; }
        String id_deportista { get; set; }
        String id_organizador { get; set; }

        public Grupo(string nombre_grupo, string id_deportista, string id_organizador)
        {
            this.nombre_grupo = nombre_grupo;
            this.id_deportista = id_deportista;
            this.id_organizador = id_organizador;
        }
        public Grupo()
        {
        }
    }
}