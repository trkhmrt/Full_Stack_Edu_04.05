using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01_WEB_API_INITIAL.Controllers
{
    //localhost
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<Test>
        [HttpGet]
        public List<string>  Get()
        {
            List<string> list = new List<string>()
            {
                "Muhammet","Engin","Nursena","Aleyna","Serdar"
            };
            
            return list;
        }

        // GET api/<Test>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Test>
        [HttpPost]
        public string Post()
        {
            return "POST İŞLEMİ TETİKLENDİ";
        }

        // PUT api/<Test>/5
        [HttpPut("{id}")]
        public int Put(int id)
        {
            return id;
        }

        // DELETE api/<Test>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (id == 1)
            {
                return true;
            }

            return false;
        }
    }
}
