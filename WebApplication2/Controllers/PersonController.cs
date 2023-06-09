using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dto;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public bool Test() { return true; }

        [HttpGet]
        public int ReturnBack(int id) { return id; }

        [HttpPost]
        public PersonDto AddPerson(PersonDto person)
        {
            return person;
        }
    }
}