using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReservasHoteles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : Controller
    {
        // GET: DefaultController
        [HttpGet]
        public string get()
        {
            return "aplicaciones corriedno";
        }

    }
}
