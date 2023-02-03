using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class Method : Declarations
    {
        public int methCount = 0;
        public override bool checkFor(Parser p,string param)
        {
            bool found = false;
            if (p.methName.Contains(param))
            { found = true; }
            return found;
        }

        public override void declare(Parser p,string name)
        {
            throw new NotImplementedException();
        }

        public override void execute()
        {
            throw new NotImplementedException();
        }

        public override int parameters()
        {
            return 1;
        }

        public override void set(Parser p,string name, int value)
        {
            this.p = p;
            if (checkFor(p,name))
            {
                p.methName[methCount] = name;
                p.methLoc[methCount++] = value;
            }
        }
    }
}
