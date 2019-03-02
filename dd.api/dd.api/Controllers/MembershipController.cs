using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dd.models;
using Microsoft.AspNetCore.Mvc;

namespace dd.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public async Task<Member> Get(Member member)
        {
            return await Task.FromResult(new Member());
        }
        
        // POST api/values
        [HttpPost]
        public async Task<Int32> Post(Member member)
        {
            return await Task.FromResult(0);
        }
    }
}