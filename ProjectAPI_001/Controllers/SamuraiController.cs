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

        [HttpGet("{id}")]
        public Samurai GetById(int id)
        {
            return repo.GetById(id);
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

        [HttpPut("{id}")]
        public Samurai UpdateById(int id, Samurai updatedSamurai)
        {
            return repo.UpdateById(id, updatedSamurai);
        }

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, Samurai samurai)
        //{
        //    var existingSamurai = repo.GetAll(id);
        //    if (existingSamurai == null)
        //    {
        //        return NotFound();
        //    }

        //    existingSamurai.Name = samurai.Name;
        //    existingSamurai.Description = samurai.Description;
        //    existingSamurai.Age = samurai.Age;

        //    repo.Update(existingSamurai);

        //    return NoContent();
        //}

    }
}
