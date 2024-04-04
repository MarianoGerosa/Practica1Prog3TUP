using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double price, [FromQuery] string paymentMethod, [FromQuery] string cardNumber = null)
        {
            paymentMethod = paymentMethod.ToLower().Trim();
            cardNumber = cardNumber.Trim();

            if (price <= 0) 
            {
                return $"El costo debe ser mayor a 0";
            }

            if (paymentMethod == "tarjeta")
            {
                if (cardNumber.Length == 16) 
                {
                    double total = price * 1.10;
                    return $"El monto total es de {total}";
                }
                else 
                {
                    return $"Se ingreso mal el número de tarjeta";
                }

            }
            else if(paymentMethod == "efectivo")
            {
                return $"El monto total es de {price}";
            }
            else 
            {
                return $"La forma de pago no es valida";
            }    
        }
    }
}