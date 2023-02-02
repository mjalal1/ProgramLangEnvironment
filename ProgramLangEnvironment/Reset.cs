using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    class Reset : DrawingCommand
    {
        int x, y;
        public Reset() : base()
        { this.parameters = 0; }

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

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Reset";
        }
        public override void execute()
        {
            canvas.posx = 0;
            canvas.posy = 0;

        }
    }
}
