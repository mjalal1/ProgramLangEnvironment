﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class CanvasO
    {
        Graphics g;
        Pen Pen;
        int posx;
        int posy;

        public CanvasO(Graphics g)
        {
            this.g = g;
            posx = posy = 0; ;
            Pen = new Pen(Color.Black, 1);
        }

        public void DrawTo(int x,int y)
        {
            g.DrawLine(Pen, posx, posy, x, y);
            posx = x;
            posy = y;

        }
        public void DrawRect(int length,int height)
        {
            g.DrawRectangle(Pen, posx, posy, posx+length, posy+height);
         

        }
        public void DrawCircle(int radius)
        {
            g.DrawEllipse(Pen, posx, posy, (posx + (radius * 2)), (posy + (radius * 2)));
        }
    }
}
