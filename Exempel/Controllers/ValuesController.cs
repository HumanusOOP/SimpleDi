using System.Collections.Generic;
using System.Globalization;
using Exempel.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Exempel.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IMyLogic _myLogic;

        public ValuesController(IMyLogic myLogic)
        {
            _myLogic = myLogic;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _myLogic.MultiplyAndAdd(10, 10).ToString(CultureInfo.InvariantCulture);

            return new string[] { result, "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
