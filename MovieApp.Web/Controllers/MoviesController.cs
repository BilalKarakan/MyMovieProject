using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var movie = new List<Movie>()
            {
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "The Lord of the Rings: The Fellowship of the Ring is a 2001 epic fantasy adventure film directed by Peter Jackson from a screenplay by Fran Walsh, Philippa Boyens, and Jackson, based on 1954's The Fellowship of the Ring, the first volume of the novel The Lord of the Rings by J. R. R. Tolkien. The film is the first installment in The Lord of the Rings trilogy. It features an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Billy Boyd, Dominic Monaghan, Orlando Bloom, Christopher Lee, Hugo Weaving, Sean Bean, Ian Holm, and Andy Serkis. Set in Middle-earth, the story tells of the Dark Lord Sauron, who seeks the One Ring, which contains part of his might, to return to power. The Ring has found its way to the young hobbit Frodo Baggins. The fate of Middle-earth hangs in the balance as Frodo and eight companions (who form the Fellowship of the Ring) begin their journey to Mount Doom in the land of Mordor, the only place where the Ring can be destroyed.",
                    Director = "Peter Jackson",
                    Players = new string[] { "Elijah Wood", "Ian McKellen", "Viggo Mortensen", "Orlando Bloom"},
                    imageUrl = "The fellowship of the ring.jpg"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Two Towers",
                    Description = "The Lord of the Rings: The Two Towers is a 2002 epic fantasy adventure film directed by Peter Jackson from a screenplay by Fran Walsh, Philippa Boyens, Stephen Sinclair, and Jackson, based on 1954's The Two Towers, the second volume of the novel The Lord of the Rings by J. R. R. Tolkien. The sequel to 2001's The Lord of the Rings: The Fellowship of the Ring, the film is the second instalment in The Lord of the Rings trilogy. It features an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Bernard Hill, Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving, Miranda Otto, David Wenham, Brad Dourif, Karl Urban, and Andy Serkis.",
                    Director = "Peter Jackson",
                    Players = new string[] {"Elijah Wood", "Ian McKellen", "Viggo Mortensen", "Orlando Bloom"},
                    imageUrl = "The two towers.jpg"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the Kıng",
                    Description = "The Lord of the Rings: The Return of the King is a 2003 epic fantasy adventure film directed by Peter Jackson from a screenplay by Fran Walsh, Philippa Boyens, and Jackson, based on 1955's The Return of the King, the third volume of the novel The Lord of the Rings by J. R. R. Tolkien. The sequel to 2002's The Lord of the Rings: The Two Towers, the film is the final installment in The Lord of the Rings trilogy. It features an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Bernard Hill, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving, Miranda Otto, David Wenham, Karl Urban, John Noble, Andy Serkis, Ian Holm, and Sean Bean.",
                    Director = "Peter Jackson",
                    Players = new string[] {"Elijah Wood", "Ian McKellen", "Viggo Mortensen", "Orlando Bloom"},
                    imageUrl = "The return of the king.jpg"
                }
            };
            return View("Movies",movie);
        }

        public string Details()
        {
            return "Film Detayı";
        }                                                                                                 
    }
}
