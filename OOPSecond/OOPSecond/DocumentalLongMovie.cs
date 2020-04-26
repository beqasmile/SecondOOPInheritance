using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class DocumentalLongMovie : Movie
    {
        private string authorName;

        public DocumentalLongMovie(int movieID, string movie) : base(movieID, movie)
        {
            this.authorName = "abc";
            
        }

        public string AuthorName { get => authorName; set => authorName = value; }

       
        public void PrintDocumentalLongMovie()
        {
            Console.WriteLine(this.authorName);
            Console.WriteLine(this.movieName);
        }


        public override string ToString()
        {
            return base.ToString() + " " + this.authorName;
        } 
    }
}
