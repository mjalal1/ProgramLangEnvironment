using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    abstract class Declarations : Command
    {
        protected Form1 form;
        protected Parser p;
        public abstract void set(Form1 f,string name);
        public abstract void declare();
        public abstract int? checkFor(Form1 f,string param);
        public override string cmdType()
        {
            return "Declare";
        }
    }
}
