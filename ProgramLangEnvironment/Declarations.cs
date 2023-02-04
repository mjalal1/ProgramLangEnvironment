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
     
        public abstract void set(Parser p,string name);
        public abstract void declare();
        public abstract int? checkFor(Parser p,string param);
        public override string cmdType()
        {
            return "Declare";
        }
    }
}
