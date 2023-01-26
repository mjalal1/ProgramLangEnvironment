using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();


            if (shapeType=="circle")
            {
                return new Circle();
            }
            else
            {
                throw new ArgumentException("Error in factory: " + shapeType+" not valid");
            }
        }

    }
}
