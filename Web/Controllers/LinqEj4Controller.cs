using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> numList)
        {
            var query = (from int num in numList
                         orderby num descending
                         select num).ToList().GetRange(0, 5); 

            return query;
        }
    }
}