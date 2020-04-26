using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecond
{
    public class DocumentalShortMovie : DocumentalMovie
    {
        private int movieLengthInFrames;

        public DocumentalShortMovie(int movieID, string movie) : base(movieID, movie)
        {
        }

        public int MovieLengthInFrames { get => movieLengthInFrames; set => movieLengthInFrames = value; }
    }
}
