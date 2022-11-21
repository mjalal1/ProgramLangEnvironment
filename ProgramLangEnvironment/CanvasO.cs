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
        int posx;
        int posy;

        public CanvasO(Graphics g)
        {
            this.g = g;
            posx = posy = 0; ;
            Pen = new Pen(Color.Black, 1);
        }
    }
}
