﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    interface IShape
    {
        void set(CanvasO c,params int[] list); //set should take the canvas and store it so draw can use it 
        void draw();
      
        void execute();
    }
}
