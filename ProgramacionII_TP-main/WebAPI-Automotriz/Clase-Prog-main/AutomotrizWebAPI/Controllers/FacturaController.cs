using Libreria.Datos;
using Libreria.Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : Controller
    {
        private HelperDB oConexion;

        public FacturaController()
        {
            oConexion = new HelperDB();
        }
        
        [HttpGet("/consultar_factura")]
        public IActionResult GetFactura(int nroFactura)
        {
            Factura fact;
            try
            {
                fact = oConexion.ObtenerFactura(nroFactura);
                return Ok(fact);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/proxima_factura")]
        public IActionResult GetProxFactura()
        {
            int prox = 0;
            try
            {
                prox = oConexion.ObtenerProxFactura();
                return Ok(prox);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/autoplanes")]
        public IActionResult GetAutoplanes()
        {
            List<Autoplan> lst = null;
            try
            {
                lst = oConexion.ObtenerAutoplanes();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;
            try
            {
                lst = oConexion.ObtenerClientes();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/empleados")]
        public IActionResult GetEmpleados()
        {
            List<Empleado> lst = null;
            try
            {
                lst = oConexion.ObtenerEmpleados();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/insertar_factura")]
        public IActionResult PostFacturas(Factura oFactura)
        {
            try
            {
                if(oFactura == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.InsertarMD(oFactura));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        
        [HttpDelete("/borrar_facturas")]
        public IActionResult DeleteFacturas(int cod)
        {
            try
            {
                return Ok(oConexion.EliminarFactura(cod));
            }
            catch(Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
