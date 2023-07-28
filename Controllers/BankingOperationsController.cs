using BankingAPI.Schemas;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingOperationsController : ControllerBase
    {
        // GET: api/<BankingOperationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BankingOperationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BankingOperationsController>
        [HttpPost]
        public BankingAPI.Schemas.AccountResponse Post(AccountRequest msgAccountRequest)
        {
            AccountResponse msgAccountResponse = new AccountResponse();
            msgAccountResponse.accountBalance = "990.50";

            return msgAccountResponse;
        }

        
        // PUT api/<BankingOperationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankingOperationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
