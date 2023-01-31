using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    public class CanvasO
    {
        public Graphics gfx;
       public Pen Pen;
        Brush brush = Brushes.Black;
        public int posx;
        public int posy;
       public bool fillo = false;
        public CanvasO(Graphics g)
        {
            this.gfx = g;
            posx = posy = 0; ;
            Pen = new Pen(Color.Black, 1);
        }


        /// <summary>
        /// drawTo command draws a line from current position to given x and y
        /// </summary>
        /// <param name="x">X co ord of end location</param>
        /// <param name="y">Y co ord of end location</param>
        public void DrawTo(int x, int y)
        {

            gfx.DrawLine(Pen, posx, posy, x, y);
            posx = x;
            posy = y;

        }


        /// <summary>
        /// moveTo moves the pen without drawing to given x and y 
        /// </summary>
        /// <param name="x">New x location</param>
        /// <param name="y">New y location</param>
        public void MoveTo(int x, int y)
        {

            posx = x;
            posy = y;

        }

        /// <summary>
        /// Resets the pen position to 0,0
        /// </summary>
        public void reset()
        {
            posx = 0;
            posy = 0;


        }


        /// <summary>
        /// Clears the graphic screen
        /// </summary>
        public void clear()
        {

            gfx.Clear(Color.Transparent);

        }


        /// <summary>
        /// sets the fill property of the pen
        /// </summary>
        /// <param name="o">on/off</param>
        public void fill(string o)
        {

            if (o == "on")
            {
                fillo = true;

            }
            else if (o == "off")
            { fillo = false; }


        }


        /// <summary>
        /// Sets pen colour
        /// </summary>
        /// <param name="colour">Colour given by user</param>
        public void pen(string colour)
        {

            switch (colour)
            {
                case "red":
                    Pen.Color = Color.Red;
                    brush = Brushes.Red;

                    break;
                case "blue":
                    Pen.Color = Color.Blue;
                    brush = Brushes.Blue;
                    break;
                case "green":
                    Pen.Color = Color.Green;
                    brush = Brushes.Green;
                    break;
                case "pink":
                    Pen.Color = Color.Pink;
                    brush = Brushes.Pink;
                    break;
                case "purple":
                    Pen.Color = Color.Purple;
                    brush = Brushes.Purple;
                    break;
                case "black":
                    Pen.Color = Color.Black;
                    brush = Brushes.Black;
                    break;
            }


        }

        /// <summary>
        /// Draws a rectangle with the given dimensions
        /// </summary>
        /// <param name="length">Length of desired rectangle</param>
        /// <param name="height">Height of desired rectangle</param>
        public void DrawRect(int length, int height)
        {

            //  g.DrawRectangle(Pen, posx, posy, posx+length, posy+height);
            Rectangle rect = new Rectangle(posx, posy, length, height);


            gfx.DrawRectangle(Pen, rect);
            if (fillo) { gfx.FillRectangle(brush, rect); }
            //  Console.WriteLine(fillo);
        }

        /// <summary>
        /// Draws a circle with the given radius
        /// </summary>
        /// <param name="radius">Radius of desired circle</param>
        public void DrawCircle(int radius)
        {

            Rectangle recta = new Rectangle(posx - radius, posy - radius, radius * 2, radius * 2);
            gfx.DrawEllipse(Pen, recta);
            if (fillo) { gfx.FillEllipse(brush, recta); }
            //  g.DrawEllipse(Pen, posx, posy, (posx + (radius * 2)), (posy + (radius * 2)));
        }


        /// <summary>
        /// Draws a triangle with the 3 co-ordinates given.
        /// </summary>
        /// <param name="x1">x position of point 1</param>
        /// <param name="y1">y position of point 1</param>
        /// <param name="x2">x position of point 2</param>
        /// <param name="y2">y position of point 2</param>
        /// <param name="x3">x position of point 3</param>
        /// <param name="y3">y position of point 3</param>
        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3) // x and y co ords of 3 points on triangle
        {
            Point[] pnt = new Point[3]; //x and y stored in Points array and used with DrawPolygon()

            pnt[0].X = x1;
            pnt[0].Y = y1;

            pnt[1].X = x2;
            pnt[1].Y = y2;

            pnt[2].X = x3;
            pnt[2].Y = y3;

            gfx.DrawPolygon(Pen, pnt);
            if (fillo) { gfx.FillPolygon(brush, pnt); }
        }




      
    }
}
