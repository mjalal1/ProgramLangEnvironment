using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
   interface Command
    {
      
        

        void set(CanvasO c, params int[] list); //set should take the canvas and store it so draw can use it 


        void execute();
    }
}
