using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class DramaMovie:Movie
    {
        private string dramaticHeroName;
        private List<string> nameOfDramaticParts;

        public string DramaticHeroName { get => dramaticHeroName; set => dramaticHeroName = value; }
        public List<string> NameOfDramaticParts { get => nameOfDramaticParts; set => nameOfDramaticParts = value; }
        public DramaMovie(int movieID, string movie, int movieLength, string movieType, MovieDirector movieDirector,string dramaticHeroName) 
            :base (movieID,movie,movieLength,movieType, movieDirector)
        {
            this.dramaticHeroName = dramaticHeroName;
        }

        public void PrintDramaMovie()
        {
            this.PrintMovie();
            Console.WriteLine(this.dramaticHeroName);
            Console.WriteLine(this.movieName);
           
        }

        public override void CalculateTypeOfTheMovie()
        {
            base.CalculateTypeOfTheMovie();
            Console.WriteLine("CalculateTypeOfTheMovie was deleted!!!");
        }

        public override string ToString()
        {

            return base.ToString() + this.dramaticHeroName;
        }
    }
}
