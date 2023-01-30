using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  abstract class DrawingCommand : IShape
    {
       protected Color colour;
       protected int x,y;
       protected int parameters;

        public DrawingCommand()
        {
            this.colour = Color.Blue;
            this.x = 150;
            this.y = 100;

        }

        public DrawingCommand(Color colour, int x, int y)
        {
            this.colour = colour;
            this.x = x;
            this.y = y;
        }

        public abstract void draw(CanvasO c);


        public abstract void set(Color colour, params int[] list);
        public abstract void set(params int[] list);
    


    }
}
