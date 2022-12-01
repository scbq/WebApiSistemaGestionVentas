using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.Controllers
{
    public class VentaController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class VentasController : Controller
        {
            private VentaController Controller = new VentaController();

            [HttpGet]
            public ActionResult<List<Venta>> Get()
            {
                try
                {
                    List<Venta> lista = GetVenta();
                    return Ok(lista);
                }
                catch (Exception ex)
                {

                    return Problem(ex.Message);
                }
            }

            private List<Venta> GetVenta()
            {
                throw new NotImplementedException();
            }
        }
    }
}
