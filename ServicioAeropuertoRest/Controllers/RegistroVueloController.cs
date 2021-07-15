using Microsoft.AspNetCore.Mvc;
using ServicioAeropuertoRest.ItemsModel;
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
    public class RegistroVueloController : ControllerBase
    {
        // GET: api/<RegistroVueloController>
        [EnableCors("Todos")]
        [HttpPost("[action]")]
        public IActionResult RegistrarVuelo([FromBody] itemRegistroVuelo itemRegistroVuelo)
        {
            try
            {
                List<Entities.Resultado> resultados = new List<Entities.Resultado>();
                Business.Vuelo vuelo = new Business.Vuelo();

                DataTable tblResult = vuelo.RegistrarVuelo(itemRegistroVuelo.fechaSalida, itemRegistroVuelo.horaSalida,
                    itemRegistroVuelo.numeroVuelo, itemRegistroVuelo.idAerolinea, itemRegistroVuelo.idEncargado, itemRegistroVuelo.tiempoAtencion);

                if(tblResult.Rows.Count > 0)
                {
                    string resultado = "";
                    foreach(DataRow fila in tblResult.Rows)
                    {
                        resultado = fila["Resultado"].ToString();
                        resultados.Add(new Entities.Resultado(resultado) { });
                    }
                }

                return Ok(resultados);

            }catch(Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }
        
    }
}
