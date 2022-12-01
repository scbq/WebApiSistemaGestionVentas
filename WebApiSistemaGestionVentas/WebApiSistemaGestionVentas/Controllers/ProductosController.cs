using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : Controller
    {
        private ProductosController Controller = new ProductosController();
        
        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            try
            {
                List<Producto> lista = GetProductos();
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }

        private List<Producto> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
