using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class Var : Declarations
    {
        int? found = null;
        public int varCount = 0;
        string name;
        int value;
        public override void declare()
        {

            if (checkFor(p, name).Equals(null))
            {
                p.varName.Add(name);
                p.varValue.Add(0);
            }
        }

        public override void execute()
        {
            //decide if it's set or declare
            declare();
        }
        public override int? checkFor(Parser p, string param)
        {
            this.p = p;

            if (p.varName.Contains(param))
            { found = p.varName.FindIndex(a => a.Contains(param)); }
            if (found == -1) { found = null; return found; }
            return found;
        }

        public override int parameters()
        {
            return 1;
        }
        public void setVal()
        {
            if (checkFor(p, name) >= 0)
            {
                p.varName.Add(name);
                p.varValue.Add(value);
            }
        }

        public override void set(Parser p, string name)
        {
            this.p = p;
            this.name = name;
           

        }
    }
}
