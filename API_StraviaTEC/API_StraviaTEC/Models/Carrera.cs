using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_StraviaTEC.Models
{
    public class Carrera
    {
        String nombre { get; set; }
        List<String> patrocinadores { get; set; }
        String recibo_pago { get; set; }
        String fecha { get; set; }
        String recorrido { get; set; }
        String tipo_actividad { get; set; }
        String privacidad { get; set; }
        String costo { get; set; }
        String cuentas_bancarias { get; set; }
        List<String> categorias { get; set; }
        String id_organizador { get; set; }
        String id_deportista { get; set; }

        public Carrera(string nombre, List<string> patrocinadores, string recibo_pago, string fecha, string recorrido, string tipo_actividad, string privacidad, string costo, string cuentas_bancarias, List<string> categorias, string id_organizador, string id_deportista)
        {
            this.nombre = nombre;
            this.patrocinadores = patrocinadores;
            this.recibo_pago = recibo_pago;
            this.fecha = fecha;
            this.recorrido = recorrido;
            this.tipo_actividad = tipo_actividad;
            this.privacidad = privacidad;
            this.costo = costo;
            this.cuentas_bancarias = cuentas_bancarias;
            this.categorias = categorias;
            this.id_organizador = id_organizador;
            this.id_deportista = id_deportista;
        }
        public Carrera()
        {
        }
    }
}