using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  abstract class Shape : IShape
    {
       protected Color colour;
       protected int x,y;

        public Shape()
        {
            this.colour = Color.Blue;
            this.x = 150;
            this.y = 100;

        }

        public Shape(Color colour, int x, int y)
        {
            this.colour = colour;
            this.x = x;
            this.y = y;
        }

        public abstract void draw(Graphics graphic);
        public abstract double calcArea();
        public abstract double calcPerim();

        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.x = list[0];
            this.y = list[1];

        }


    }
}
