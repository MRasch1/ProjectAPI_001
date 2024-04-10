using Microsoft.AspNetCore.Mvc;
using ProjectAPI_001_Repository.Interfaces;
using ProjectAPI_001_Repository.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectAPI_001.Controllers
{
    [Route("api/[controller]")] // our URL
    [ApiController] // Will be explained later
    public class SamuraiController : ControllerBase
    {
        private readonly ISamuraiRepository repo;

        public SamuraiController(ISamuraiRepository repo)
        {
            this.repo = repo;
        }



        //get: api/<samuraicontroller>
        [HttpGet] // this is a dataannotation / attribute
        public List<Samurai> GetAll()
        {
            // If I want to DEBUG
            return repo.GetAll();
        }
        

        // Create: api/<SamuraiController>
        [HttpPost]
        public void Create(Samurai samurai)
        {
            //Samurai s = new Samurai();
            //samurai.Name = "Jens";
            //samurai.Descripton = "Han er sej";
            //samurai.Age = 42;
            repo.Create(samurai);

        }

        

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<SamuraiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SamuraiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
