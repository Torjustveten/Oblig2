using System;

namespace Oblig2
{
    
    abstract class Piece
        {
            public string Symbol { get; set; }

            protected Piece()
            {
            }

            public abstract bool Move(string fromPosition, string toPosition);
        }
}

