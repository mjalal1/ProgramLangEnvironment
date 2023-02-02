using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    class Triangle : DrawingCommand
    {

        Point[] pnt = new Point[3];

        public Triangle() : base()
        { this.parameters = 6; }

        public Triangle(Color colour,int x1, int y1, int x2, int y2, int x3, int y3)
        {
            pnt[0].X = x1;
            pnt[0].Y = y1;

            pnt[1].X = x2;
            pnt[1].Y = y2;

            pnt[2].X = x3;
            pnt[2].Y = y3;
        }

        public override void set(CanvasO canvas, params int[] list)
        {
            this.canvas = canvas;
            this.pnt[0].X = list[0];
            this.pnt[0].Y = list[1];

            this.pnt[1].X = list[2];
            this.pnt[1].Y = list[3];

            this.pnt[2].X = list[4];
            this.pnt[2].Y = list[5];
        }

        public override void set(params int[] list)
        {
            this.pnt[0].X = list[0];
            this.pnt[0].Y = list[1];

            this.pnt[1].X = list[2];
           this. pnt[1].Y = list[3];

           this. pnt[2].X = list[4];
           this. pnt[2].Y = list[5];
        }
        public override void draw()
        {
            Pen p = new Pen(colour, 2);
            SolidBrush b = new SolidBrush(colour);

            canvas.gfx.DrawPolygon(p, pnt);
            if (canvas.fillo) { canvas.gfx.FillPolygon(b, pnt); }

        }
        public override void execute()
        {
            draw();
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
