using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    abstract class FigureBase
    {
        protected readonly string _whichPiece;
        public string WhichPiece { get; }
        public string ItemType { get; protected set; }
        public FigureBase(string whichPiece)
        {
            _whichPiece = whichPiece;
        }

        public virtual void GetPiece()
        {
            Console.WriteLine($"What type of {_whichPiece} do you want?");
            Console.WriteLine("Press 1 for generic");
            Console.WriteLine("Press 2 for metallic");
            Console.WriteLine("Press 3 for fancy");
            var pieceType = Console.ReadLine();
            if (pieceType == "1")
            {
                ItemType = "generic";
            }
            else if (pieceType == "2")
            {
                ItemType = "metallic";
            }
            else if (pieceType == "3")
            {
                ItemType = "fancy";
            }
            else
            {
                Console.WriteLine($"You have decided to forego a {_whichPiece}. That's awkward but totally your decision.");
            }
        }

        public abstract void GetFunctionality();
    }
}
