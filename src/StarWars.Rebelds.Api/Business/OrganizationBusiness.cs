using StarWars.Rebelds.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Rebelds.Api.Business
{
    public class OrganizationBusiness
    {
        public List<Person> Persons() {

            var list = new List<Person>();

            list.Add(new Person() { Name = "General Leia Organa", Rank = "Commander in chief" });
            list.Add(new Person() { Name = "Admiral Amilyn Holdo[2]", Rank = "" });

            return list;
        }
    }
}
