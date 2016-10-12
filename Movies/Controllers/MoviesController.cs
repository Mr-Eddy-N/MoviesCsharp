using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Movies.Controllers
{
    public class MoviesController : ApiController
    {

        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            moviesContext db = new moviesContext();
            List<Movies> items = db.Movies.ToList();
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetMovie(Guid id)
        {
            moviesContext db = new moviesContext();
            Movies items = db.Movies.Where(x => x.ID == id).FirstOrDefault();
            db.Dispose();
            return Ok(items);
        }

        [HttpGet]
        public IHttpActionResult GetSaludo()
        {
           // List<int> l = new List<int>() { 1, 2, 3 };
            return Ok("Holi");
            // return Ok(new List<int>() { 1, 2, 3 });
        }
        [HttpPost]
        public IHttpActionResult SetMovie(Movies movie)
        {
            movie.ID = new Guid();
            
            moviesContext db = new moviesContext();
            db.Movies.Add(movie);
            db.SaveChanges();
            return Ok("OK");

        }

    }
}
