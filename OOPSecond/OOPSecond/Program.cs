using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(5,"Titanick");
           
            // x.movieName
            MovieDirector movieDirector = new MovieDirector("firstDirector");
            DramaMovie dramaMovie = new DramaMovie(22, "Titanick", 33,"drama", movieDirector,  "My first drama");


            dramaMovie.CalculateTypeOfTheMovie(); // drama movie was overrided
            movie.CalculateTypeOfTheMovie();
            Movie movie1 = dramaMovie;
            movie1.CalculateTypeOfTheMovie(); 
        }
    }
}
