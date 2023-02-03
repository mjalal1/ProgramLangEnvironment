using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    abstract class Declarations : Command
    {
        protected Parser p;
     
        public abstract void set(Parser p,string name,int value);
        public abstract void declare(Parser p,string name);
        public abstract bool checkFor(Parser p,string param);
        public override string cmdType()
        {
            return "Declare";
        }
    }
}
