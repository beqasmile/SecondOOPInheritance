using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class ActionMovie : Movie
    {
        private List<String> nameOfStuntmen;

        public ActionMovie(int movieID, string movie) : base(movieID, movie)
        {
            this.nameOfStuntmen = new List<string>();
        }

        public List<string> NameOfStuntmen { get => nameOfStuntmen; set => nameOfStuntmen = value; }

        public override string ToString()
        {
            return base.ToString() + this.nameOfStuntmen.ToString();
        }

    }
}
