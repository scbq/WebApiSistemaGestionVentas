using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private UsuarioController Controller = new UsuarioController();

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            try
            {
                List<Usuario> lista = GetUsuario();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        private List<Usuario> GetUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
