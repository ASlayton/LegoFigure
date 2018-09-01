using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    class Legs : FigureBase
    {
        public Legs() : base("Legs")
        { }

        // Add a method to determine the actions available with this part type
        public override void GetFunctionality()
        {
            Console.WriteLine($"{ItemType}");
        }
    }
}
