using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class AppMovil
    {
        String gps { get; set; }
        String tiempo { get; set; }
        String id_deportista { get; set; }
        public AppMovil(string gps, string tiempo, string id_deportista)
        {
            this.gps = gps;
            this.tiempo = tiempo;
            this.id_deportista = id_deportista;
        }
        public AppMovil()
        {
        }
    }
}