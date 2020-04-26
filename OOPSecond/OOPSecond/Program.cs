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

           

            DramaMovie movieDrama = new DramaMovie(22, "Titanick", 33, "drama", movieDirector, "My second drama");
            ComedyMovie movieComedy = new ComedyMovie(55, "Masc", 33);
            ActionMovie movieAction = new ActionMovie(11,"Action movie number 1");
            DocumentalMovie movieDoc = new DocumentalMovie(33,"My Documental Movie");

            Console.WriteLine(movieDrama);
            Console.WriteLine(movieComedy);
            Console.WriteLine(movieAction);


            movieDrama.DramaticHeroName = "Robert De Niro";
            movieDrama.SetMovieName("Once upon a time in America");
            movieDrama.SetMovieLength(280);


            movieComedy.SetMovieName("Back 2 the future");
            movieComedy.NumberOfComicHeroes = 3;
            List<string> stunmenList = new List<string>();
            movieComedy.SetMovieLength(120);

            movieAction.SetMovieName("The best Action movie");
            stunmenList.Add("Michael Moor");
            stunmenList.Add("Andy Root");
            stunmenList.Add("Michael J Fox");
            movieAction.NameOfStuntmen = stunmenList;
            movieAction.SetMovieLength(150);

            movieDrama.SetMovieName("Ace of Base");
            List<string> dramaParts = new List<string>();
            dramaParts.Add("part 1");
            dramaParts.Add("part 2");
            dramaParts.Add("part 3");
            movieDrama.NameOfDramaticParts = dramaParts;
            movieDrama.SetMovieLength(30);

            Console.WriteLine(movie);
        }
    }
}
