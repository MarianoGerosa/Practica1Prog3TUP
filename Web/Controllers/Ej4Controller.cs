using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EJ4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int number1, [FromQuery] int number2)
        {
            if (number1 > number2)
            {
                return $"El número mayor es {number1}";
            }
            else if (number1 < number2)
            {
                return $"El número mayor es {number2}";
            }
            return $"Los numeros son iguales";
        }
    }
}