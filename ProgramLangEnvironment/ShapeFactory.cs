using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  public  class ShapeFactory
    {
        public ICommand GetCmd(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();


            if (shapeType.Equals("circle"))
            {
                return new Circle(); // create classes for other commands
            }
           else if (shapeType.Equals("rect"))
            {
                return new Rect(); 
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle(); 
            }
            else if (shapeType.Equals("drawto"))
            {
                return new DrawTo();
            }
            else if (shapeType.Equals("moveto"))
            {
                return new MoveTo();
            }
            else if (shapeType.Equals("reset"))
            {
                return new Reset();
            }
            else if (shapeType.Equals("clear"))
            {
                return new Clear();
            }
            else if (shapeType.Equals("load"))
            {
                return new Load();
            }
            else if (shapeType.Equals("save"))
            {
                return new Save();
            }
            else if (shapeType.Equals("var"))
            {
                return new Var();
            }
            else if (shapeType.Equals("method"))
            {
                return new Method();
            }
            else if (shapeType.Equals("call"))
            {
                return new Method();
            }
            else if (shapeType.Equals("loop"))
            {
                return new Loop();
            }
            else if (shapeType.Equals("run"))
            {
                return new Run();
            }
            else if (shapeType.Equals("if"))
            {
                return new ConditionalCmd();
            }
            else
            {
                throw new ApplicationException("[FACTORY]: Command not recognised\nValid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");
            }
        }

    }
}
