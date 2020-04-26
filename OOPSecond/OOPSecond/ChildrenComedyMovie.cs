using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class ChildrenComedyMovie : ComedyMovie
    {
        private int childrenMinimumAge;

        public ChildrenComedyMovie(int movieID, string movie, int numberOfComicHeroes, int childrenMinimumAge) : base(movieID, movie, numberOfComicHeroes)
        {
            this.childrenMinimumAge = childrenMinimumAge;
        }
    }
}
