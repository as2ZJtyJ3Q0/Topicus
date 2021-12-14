
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Logic;
using WebApplication1.Objects;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicusController : ControllerBase
    {
        [Route("")]
        public string Get()
        {
            string json = JsonConvert.SerializeObject(true);
            return json;
        }
        [Route("medicine")]
        public string GetMedicine()
        {
            string json = JsonConvert.SerializeObject(InformationLogic.GetMedicine());
            return json;
        }
    }
}
