using Microsoft.AspNetCore.Mvc;
using IServices;

namespace DIExample.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ICountriesService _countriesService;

        public HomeController(ICountriesService countriesService)
        {
            _countriesService = countriesService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> countries = _countriesService.GetCountries();
            return View(countries);
        }
    }
}
