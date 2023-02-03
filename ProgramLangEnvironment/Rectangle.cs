using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramLangEnvironment
{
    class Rect : DrawingCommand
    {
        int length,height;

        public Rect() : base()
        { }

        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            this.length = list[0];
            this.height = list[1];
        }

        public override string ToString()
        {
            return "Rectangle";
        }
        public override int parameters()
        {
            return 2;
        }

        public override void execute()
        {
            draw();
        }

        public override void set(params int[] list)
        {
            this.length = list[0];
            this.height = list[1];
        }
        public override void draw()
        {
            Pen p = new Pen(colour, 2);
            SolidBrush b = new SolidBrush(colour);

            Rectangle rect = new Rectangle(canvas.posx, canvas.posy, length, height);


            canvas.gfx.DrawRectangle(p, rect);
            if (canvas.fillo) { canvas.gfx.FillRectangle(b, rect); }

        }

    }
}
