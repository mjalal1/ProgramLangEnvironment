﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    class MoveTo : DrawingCommand
    {
        int x, y;
        public MoveTo() : base()
        {}

        public override int parameters()
        {
            return 2;
        }
        public override void set(CanvasO canvas, params int[] list)
        {
            base.set(canvas, list);
            this.x = list[0];
            this.y = list[1];
        }

        public override void set(params int[] list)
        {

            this.x = list[0];
            this.y = list[1];
        }

        public override void draw()
        {
            canvas.posx = x;
            canvas.posy = y;
        }

        public override string ToString()
        {
            return "MoveTo";
        }
        public override void execute()
        {
            draw();
        }
    }
}
