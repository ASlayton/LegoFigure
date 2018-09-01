using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    class LeftArm : FigureBase
    {
        public LeftArm() : base("Left Arm")
        { }

        // Add a method to determine the actions available with this part type
        public override void GetFunctionality()
        {
            Console.WriteLine($"{ItemType}");
        }
    }
}
