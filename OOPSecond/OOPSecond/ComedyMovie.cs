using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class ComedyMovie: Movie
    {
        private int numberOfComicHeroes;

        public int NumberOfComicHeroes { get => numberOfComicHeroes; set => numberOfComicHeroes = value; }
        public ComedyMovie(int movieID, string movie,int numberOfComicHeroes)
            :base (movieID,movie)
        {
            this.numberOfComicHeroes = numberOfComicHeroes;
        }

        public ComedyMovie(int movieID, string movie, int movieLength, string movieType, MovieDirector movieDirector,int numberOfComicHeroes)
            :base (movieID,movie,movieLength,movieType,movieDirector)
        {
            this.numberOfComicHeroes = numberOfComicHeroes;
        }
    }
}
