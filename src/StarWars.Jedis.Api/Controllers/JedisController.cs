﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StarWars.Jedis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JedisController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Jedi1", "Jedi2" };
        }

      
    }
}
