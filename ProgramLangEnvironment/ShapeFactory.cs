using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class ShapeFactory
    {
        public DrawingCommand GetCmd(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();


            if (shapeType.Equals("circle"))
            {
                return new Circle(); // create classes for other commands
            }
            else
            {
                throw new ArgumentException("Error in factory: " + shapeType+" not valid");
            }
        }

    }
}
