using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Vuelo
    {
        public DataTable RegistrarVuelo(string fechaSalida, string horaSalida, string numeroVuelo, string idAerolinea, string idEncargado, string tiempoAtencion)
        {
            Data.Vuelo vuelo = new Data.Vuelo();
            DataTable tblResult = vuelo.RegistrarVuelo(fechaSalida, horaSalida, numeroVuelo, idAerolinea, idEncargado, tiempoAtencion);
            return tblResult;
        }

        public DataTable InformaconVuelo()
        {
            Data.Vuelo vuelo = new Data.Vuelo();
            DataTable tblResult = vuelo.InformaconVuelo();
            return tblResult;
        }
    }
}
