using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioAeropuertoRest.Controllers
{
    [EnableCors("Todos")]
    [Route("api/[controller]")]
    [ApiController]
    public class InformacionVuelosController : ControllerBase
    {
        [EnableCors("Todos")]
        [HttpGet("[action]")]
        public IActionResult InformaconVuelo()
        {
            try
            {
                Business.Vuelo vuelo = new Business.Vuelo();
                DataTable tblResult = vuelo.InformaconVuelo();
                List<Entities.ListaVuelos> listaVuelos = new List<Entities.ListaVuelos>();
                if (tblResult.Rows.Count > 0)
                {

                    string fechaSalda = "", HoraVuelo = "", numeroVuelo = "", Aerolinea = "", Encargado = "", tiempoAtencion = "";
                    foreach(DataRow fila in tblResult.Rows)
                    {
                        fechaSalda = fila["fechaSalida"].ToString();
                        HoraVuelo = fila["HoraVuelo"].ToString();
                        numeroVuelo = fila["numeroVuelo"].ToString();
                        Aerolinea = fila["Aerolinea"].ToString();
                        Encargado = fila["Encargado"].ToString();
                        tiempoAtencion = fila["tiempoAtencion"].ToString();

                        listaVuelos.Add(new Entities.ListaVuelos(fechaSalda, HoraVuelo, numeroVuelo, Aerolinea, Encargado, tiempoAtencion) { });

                    }
                
                }

                return Ok(listaVuelos);

            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }
    }
}
