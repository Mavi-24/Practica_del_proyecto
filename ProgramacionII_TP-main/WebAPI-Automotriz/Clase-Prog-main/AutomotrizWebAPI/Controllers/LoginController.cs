using Libreria.Datos;
using Libreria.Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private HelperDB oConexion;

        public LoginController()
        {
            oConexion = new HelperDB();
        }

        [HttpGet("/login")]
        public IActionResult GetLogin(string user, string pass)
        {
            int res;
            try
            {
                res = oConexion.Login(user, pass);
                return Ok(res);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
