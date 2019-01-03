using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Security;
using Microsoft.AspNetCore.Mvc;

namespace RepositoryEFDotnet.Services.WebApi.Default.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [DynamicClaimRequirement(ClaimTypes.All, "CanReadResource")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [DynamicClaimRequirement(ClaimTypes.All, "CanReadResource")]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            if (1 != 1)
            {
                return NotFound();
            }

            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id == -1)
            {
                return NotFound();
            }

            return Ok("value");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
