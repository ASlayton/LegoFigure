using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    abstract class FigureBase
    {
        protected readonly string _whichPiece;
        public string WhichPiece { get; }

        public FigureBase(string whichPiece)
        {
            _whichPiece = whichPiece;
        }

        public virtual void GetPiece()
        {
            Console.WriteLine($"What type of {_whichPiece} do you want?");
            Console.WriteLine("Press 1 for metallic");
            Console.WriteLine("Press 2 for Generic");
            Console.WriteLine("Press 3 for Horse");
            var pieceType = Console.ReadLine();
            var itemType = "";
            if (pieceType == "1")
            {
                itemType = "generic";
            }
            else if (pieceType == "2")
            {
                itemType = "metallic";
            }
            else if (pieceType == "3")
            {
                itemType = "fancy";
            }
            else
            {
                itemType = "Asses";
            }

            PrintPiece(itemType);
        }

        public void PrintPiece(string item)
        {
            Console.WriteLine($"You have a {item} {_whichPiece}");
        }
    }
}
