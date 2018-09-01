using System;
using LegoFigures.Pieces;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var getHead = new Head();
            var getHeadCovering = new HeadCovering();
            var getLeftArm = new LeftArm();
            var getRightArm = new RightArm();
            var getLegs = new Legs();
            Console.WriteLine("You have been given a basic body piece. It is up to you to create the perfect specimen of Legohood.");
            var figureItems = new FigureBase[] { getHead, getHeadCovering, getLeftArm, getRightArm, getLegs };
            foreach (var piece in figureItems)
            {
                piece.GetPiece();
            }
            Console.WriteLine("Press Enter to Escape");
        }
    }
}
