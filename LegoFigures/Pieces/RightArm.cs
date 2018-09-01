using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Pieces
{
    class RightArm : FigureBase
    {
        public RightArm() : base("Right Arm")
        {
        }

        // Add a method to determine the actions available with this part type
        public override void GetFunctionality()
        {
            if (ItemType == "")
            {

            }
            Console.WriteLine($"{ItemType}");
        }
    }
}
