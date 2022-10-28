using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string movieName = "A Movie";
            string movieDescription = "A Description";
            string movieDirector = "A Director";
            string[] players = { "A Player", "B Player", "C Player", "D Player" };

            var movie = new Movie();

            movie.Title = movieName;
            movie.Description = movieDescription;
            movie.Director = movieDirector;
            movie.Players = players;
            movie.imageUrl = "movies.jpg";

            return View(movie);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
