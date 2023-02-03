using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
 public  interface ICommand
    {



        //set should take the canvas and store it so draw can use it 
        int parameters();
        string cmdType();
        void execute();
    }
}
