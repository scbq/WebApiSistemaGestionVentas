using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.Controllers
{
    public class ProductoVendidoController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class ProductosVendidoController : Controller
        {
            private ProductoVendidoController Controller = new ProductoVendidoController();

            [HttpGet]
            public ActionResult<List<ProductoVendido>> Get()
            {
                try
                {
                    List<ProductoVendido> lista = GetProductosVendidos();
                    return Ok(lista);
                }
                catch (Exception ex)
                {

                    return Problem(ex.Message);
                }
            }

            private List<ProductoVendido> GetProductosVendidos()
            {
                throw new NotImplementedException();
            }
        }
    }
}
