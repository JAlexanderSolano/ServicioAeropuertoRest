using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioAeropuertoRest.ItemsModel
{
    public class itemRegistroVuelo
    {
        public string fechaSalida  { get; set; }
        public string horaSalida { get; set; }

        public string numeroVuelo { get; set; }

        public string idAerolinea { get; set; }

        public string idEncargado { get; set; }
        public string tiempoAtencion { get; set; }



    }
}
