using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  abstract class DrawingCommand : Command
    {
       protected Color colour;
       protected int x,y;
        public int parameters;
        protected CanvasO canvas;

        public DrawingCommand()
        {
            this.colour = Color.Blue;
            this.x = 150;
            this.y = 100;

        }

        public DrawingCommand(CanvasO canvas, int x, int y)
        {
            this.canvas = canvas;
            this.x = x;
            this.y = y;
        }

        public abstract void draw();
        // 

        public abstract void set(CanvasO canvas, params int[] list);
        public abstract void set(params int[] list);

        public abstract void execute();

    }
}
