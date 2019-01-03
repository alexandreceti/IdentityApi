using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityApi.Models;

namespace IdentityApi.Controllers
{
    [Route("IdentityApi/v1/[controller]")]
    public class IdentityController : Controller
    {
        // GET api/values/5
        [HttpGet("tokenvalido/{token}")]
        public async Task<bool> Get(string token)
        {
            return string.IsNullOrEmpty(token) ? false : true;
        }

        // POST api/values
        [HttpPost]
        public async Task<Identity> Post([FromBody]PostRequest request)
        {
            return new Identity
            {
                IdUsuario = 1,
                Login = "teste",
                Token = Guid.NewGuid().ToString()
            };
        }
    }
}
