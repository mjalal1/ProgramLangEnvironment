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
        void set(Color colour, params int[] list);
        void draw(Graphics graphic);
        double calcArea();
        double calcPerim();
    }
}
