using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramLangEnvironment
{
    class Circle : Shape
    {
        int radius;
         
        public Circle() : base()
        {  }

        public Circle(Color colour, int x, int y, int radius) : base(colour,x,y)
        {
            this.radius = radius;
        }

        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.radius = list[2];
        }
        public override void draw(Graphics graphic)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            Rectangle recta = new Rectangle(x - radius, y - radius, radius * 2, radius * 2);
            graphic.DrawEllipse(p, recta);
         //   if (fillo) {
                graphic.FillEllipse(b, recta); 
          //  }
        
        }
        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }
        public override double calcPerim()
        {
            return (2 * Math.PI * radius);
        }



    }
}
