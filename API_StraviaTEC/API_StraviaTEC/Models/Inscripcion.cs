using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Inscripcion
    {
        String estado { get; set; }
        String id_organizador { get; set; }
        String id_deportista { get; set; }

        public Inscripcion(string estado, string id_organizador, string id_deportista)
        {
            this.estado = estado;
            this.id_organizador = id_organizador;
            this.id_deportista = id_deportista;
        }
        public Inscripcion()
        {
        }
    }
}