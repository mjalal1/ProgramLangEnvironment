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
           else if (shapeType.Equals("rect"))
            {
                return new Rect(); // create classes for other commands
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle(); // create classes for other commands
            }
            else
            {
                throw new ApplicationException("Command not recognised\nValid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");
            }
        }

    }
}
