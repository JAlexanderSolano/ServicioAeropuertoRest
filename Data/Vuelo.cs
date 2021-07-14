using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Vuelo
    {
        public DataTable RegistrarVuelo(string fechaSalida, string horaSalida, string numeroVuelo, string idAerolinea, string idEncargado, string tiempoAtencion)
        {
            string Query = String.Format("exec [dbo].[sp_RegistrarVuelo] '{0}','{1}',{2},{3},{4},{5}", fechaSalida, horaSalida, numeroVuelo, idAerolinea, idEncargado, tiempoAtencion);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }

        public DataTable InformaconVuelo()
        {
            string Query = String.Format("exec [dbo].[sp_ObtenerRegistroVuelo]");
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
