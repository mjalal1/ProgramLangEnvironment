using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramLangEnvironment
{
    class Circle : DrawingCommand
    {
        int radius;
      
        public Circle() : base()
        { this.parameters = 1; }

        public Circle(Color colour, int x, int y, int radius) : base(colour,x,y)
        {
            this.radius = radius;
        }

        public override void set(Color colour, params int[] list)
        {
            this.colour = colour; 
           this.radius = list[0];
        }

        public override void set( params int[] list) 
        {
            this.radius = list[0];
        }
        public override void execute(CanvasO canvas)
        {
            Pen p = new Pen(colour, 2);
            SolidBrush b = new SolidBrush(colour);
           
            Rectangle recta = new Rectangle(x - radius, y - radius, radius * 2, radius * 2);
            canvas.gfx.DrawEllipse(p, recta);
            if (canvas.fillo) {
                canvas.gfx.FillEllipse(b, recta); 
            }
        
        }

    }
}
