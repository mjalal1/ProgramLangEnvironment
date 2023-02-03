using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  abstract  class StoreCmd : Command
    {
        protected Form1 form;
       protected string filePath;
        public override string cmdType()
        {
            return "Store";
        }
    }
}
