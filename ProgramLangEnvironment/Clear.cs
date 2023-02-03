using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    class Clear : DrawingCommand
    {
       
        public Clear() : base()
        { }

        public override int parameters()
        {
            return 0;
        }
        public override void set(CanvasO canvas, params int[] list)
        {
            this.canvas = canvas;

        }

        public override void set(params int[] list)
        {

            this.x = list[0];
            this.y = list[1];
        }

        public override void draw()
        {
            canvas.gfx.Clear(Color.Transparent);
        }

        public override string ToString()
        {
            return "Clear";
        }
        public override void execute()
        {
            draw();

        }
    }
}
