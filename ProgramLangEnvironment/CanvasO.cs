using System;
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
       Brush brush = Brushes.Black;
        int posx;
        int posy;
     bool fillo=false;
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

        public void MoveTo(int x, int y)
        {
           
            posx = x;
            posy = y;

        }


        public void reset()
        {
            posx = 0;
            posy = 0;
         

        }

        public void clear()
        {

            g.Clear(Color.Transparent);

        }

        public void fill(string o)
        {

            if (o=="on")
            {
                fillo = true;
               
            }
           else if (o=="off")
                { fillo = false; }


        }


        public void DrawRect(int length,int height)
        {
         
          //  g.DrawRectangle(Pen, posx, posy, posx+length, posy+height);
            Rectangle rect = new Rectangle(posx, posy, length,height);
          
          
                g.DrawRectangle(Pen, rect);
            if (fillo) { g.FillRectangle(brush, rect); }
            Console.WriteLine(fillo);
        }
        public void DrawCircle(int radius)
        {
           
            Rectangle recta = new Rectangle(posx - radius, posy - radius, radius * 2, radius * 2);
            g.DrawEllipse(Pen, recta);
            if (fillo) { g.FillEllipse(brush, recta); }
            //  g.DrawEllipse(Pen, posx, posy, (posx + (radius * 2)), (posy + (radius * 2)));
        }
        public void DrawTriangle(int x1,int y1,int x2, int y2,int x3, int y3) // x and y co ords of 3 points on triangle
        {
            Point[] pnt = new Point[3]; //x and y stored in Points array and used with DrawPolygon()

            pnt[0].X = x1;
            pnt[0].Y = y1;

            pnt[1].X = x2;
            pnt[1].Y = y2;

            pnt[2].X = x3;
            pnt[2].Y = y3;

            g.DrawPolygon(Pen, pnt);
        }
    }
}
