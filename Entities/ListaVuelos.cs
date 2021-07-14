using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ListaVuelos
    {
        public string fechaSalida { get; set; }
        public string HoraVuelo { get; set; }

        public string numeroVuelo { get; set; }
        public string Aerolinea { get; set; }
        public string Encargado { get; set; }
        public string tiempoAtencion { get; set; }

        public ListaVuelos(string fechaSalida, string horaVuelo, string numeroVuelo, string aerolinea, string encargado, string tiempoAtencion)
        {
            this.fechaSalida = fechaSalida;
            this.HoraVuelo = horaVuelo;
            this.numeroVuelo = numeroVuelo;
            this.Aerolinea = aerolinea;
            this.Encargado = encargado;
            this.tiempoAtencion = tiempoAtencion;
        }

        public ListaVuelos() { }
    }
}
