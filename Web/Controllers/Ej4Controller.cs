using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public int Get([FromQuery] int var1, [FromQuery] int var2)
        {
            int mayor = var1 + var2;
            return mayor;
        }
    }
}
