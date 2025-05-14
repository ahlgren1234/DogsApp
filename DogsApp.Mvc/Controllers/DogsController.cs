using Microsoft.AspNetCore.Mvc;
using DogsApp.Mvc.Models;
using DogsApp.Mvc.Services;

namespace DogsApp.Mvc.Controllers
{
    public class DogsController : Controller
    {
        static DogServices dogService = new DogServices();
        
        [Route("")]
        public IActionResult Index()
        {
            var dogs = dogService.GetAllDogs();
            return View(dogs);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(Dog dog)
        {
            dogService.AddDog(dog);
            return RedirectToAction(nameof(Index),
            new { id = dog.Id });


        }

        
    }
}
