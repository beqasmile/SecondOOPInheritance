using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class DocumentalLongMovie : Movie
    {
        private String authorName;

        public string AuthorName { get => authorName; set => authorName = value; }

        public DocumentalLongMovie(int movieID, string movie, int movieLength, string movieType, MovieDirector movieDirector, string dramaticHeroName)

        {

        }

        public void PrintDocumentalLongMovie()
        {
            Console.WriteLine(this.authorName);
            Console.WriteLine(this.movieName);
        }
    }
}
