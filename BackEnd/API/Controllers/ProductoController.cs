using DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ProductoNegocio prd = new ProductoNegocio();
            List<Producto> lst =  prd.ListarTodo();

            return Ok(lst);
        }
    }
}
