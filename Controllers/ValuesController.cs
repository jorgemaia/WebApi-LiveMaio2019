using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_LiveMaio2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        IRepo _rep; 
        public ValuesController(IRepo repositorio)
        {
            _rep = repositorio; 
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Device>> Get()
        {
            return _rep.GetDevices(); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<Device>> Post([FromBody] Device dispositivo)
        {
            _rep.Insert(dispositivo);
            return _rep.GetDevices();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Device dispositivo)
        {
            _rep.Update(id, dispositivo.DeviceName);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
