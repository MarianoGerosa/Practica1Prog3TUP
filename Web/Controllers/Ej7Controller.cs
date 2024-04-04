using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get() 
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }
    }
}
