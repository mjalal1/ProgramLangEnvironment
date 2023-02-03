using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    public abstract class DrawingCommand : Command
    {
        protected Color colour;
        protected int x, y;
        

        protected CanvasO canvas;

        public DrawingCommand()
        {

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

        public override string cmdType()
        {
            return "Draw";
        }
        public virtual void set(CanvasO canvas, params int[] list)
        {
            this.canvas = canvas;
            this.colour = canvas.Pen.Color;
        }
        

        public abstract void set(params int[] list);
        // 



    }
}
