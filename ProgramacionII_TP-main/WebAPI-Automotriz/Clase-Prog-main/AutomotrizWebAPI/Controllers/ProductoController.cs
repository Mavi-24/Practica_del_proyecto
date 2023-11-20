using Libreria.Dominio;
using Libreria.Datos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private HelperDB oConexion;

        public ProductoController()
        {
            oConexion = new HelperDB();
        }

        [HttpGet("/modelos")]
        public IActionResult GetModelos()
        {
            List<Modelo> lst = null;
            try
            {
                lst = oConexion.ObtenerModelos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpGet("/tipos_vehiculos")]
        public IActionResult GetTiposVehiculos()
        {
            List<TipoVehiculo> lst = null;
            try
            {
                lst = oConexion.ObtenerTiposVehiculos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tipos_empleado")]
        public IActionResult GetTiposEmpleado()
        {
            List<TipoEmpleado> lst = null;
            try
            {
                lst = oConexion.ObtenerTiposEmpleado();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/insert_empleado")]
        public IActionResult PostEmpleados(Empleado oEmpleado)
        {
            try
            {
                if (oEmpleado == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.InsertarEmpleado(oEmpleado));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpGet("/autopartes")]
        public IActionResult GetProductos() 
        {
            List<Producto> lst = null;
            try
            {
                lst = oConexion.ObtenerAutopartes();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/automoviles")]
        public IActionResult GetAutomoviles()
        {
            List<Producto> lst = null;
            try
            {
                lst = oConexion.ObtenerAutomoviles();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


    

        [HttpPost("/autoparte")]
        public IActionResult PostAutoparte(Autoparte oAutoparte)
        {
            try
            {
                if (oAutoparte == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.InsertarAutoparte(oAutoparte));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPut("/modificar_autoparte")]
        public IActionResult PutAutoparte(Autoparte oAutoparte)
        {
            try
            {
                if (oAutoparte == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.ModificarAutoparte(oAutoparte));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/automovil")]
        public IActionResult PostAutomovil(Automovil oAutomovil)
        {
            try
            {
                if (oAutomovil == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.InsertarAutomovil(oAutomovil));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPut("/modificar_automovil")]
        public IActionResult PutAutomovil(Automovil oAutomovil)
        {
            try
            {
                if (oAutomovil == null)
                {
                    return BadRequest("Datos incorrectos!");
                }
                return Ok(oConexion.ModificarAutomovil(oAutomovil));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}