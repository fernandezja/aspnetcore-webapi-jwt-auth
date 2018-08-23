using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarWars.Rebelds.Api.Business;
using StarWars.Rebelds.Api.Entities;

namespace StarWars.Rebelds.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrganizationController : ControllerBase
    {

        [HttpGet("list")]
        public List<Person> GetList()
        {
            var orgBusiness = new OrganizationBusiness();

            return orgBusiness.Persons();
        }

    }
}
