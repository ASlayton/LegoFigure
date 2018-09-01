using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    class Head : FigureBase
    {
        public Head() : base("Head")
        { }

        // Add a method to determine the actions available with this part type
        public override void GetFunctionality()
        {
            Console.WriteLine($"{ItemType}");
        }
    }
}
