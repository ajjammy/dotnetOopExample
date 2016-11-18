using OOPExample.Library;
using System.Web.Http;

namespace OOPExample.WebApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Nadat",
                LastName = "Kukimiya"
            };

            return Ok(employee);
        }
    }
}
