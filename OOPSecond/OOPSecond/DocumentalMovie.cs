using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class DocumentalMovie : Movie
    {
        private int dateOfFilming;
        private bool basedOnReal;

        public DocumentalMovie(int movieID, string movie) : base(movieID, movie)
        {
        }

        public int DateOfFilming { get => dateOfFilming; set => dateOfFilming = value; }
        public bool BasedOnReal { get => basedOnReal; set => basedOnReal = value; }
    }
}
