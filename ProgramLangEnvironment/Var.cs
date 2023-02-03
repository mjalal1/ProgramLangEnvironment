using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class Var : Declarations
    {
        public int varCount = 0;
        public override void declare(string name)
        {
            if (!checkFor(name))
            {
                this.varName[varCount] = name;
                this.varValue[varCount++] = 0;
            }
        }

        public override void execute()
        {
            //decide if it's set or declare
            throw new NotImplementedException();
        }
        public override bool checkFor(string param)
        {
            bool found = false;
            if (varName.Contains(param))
            { found = true; }
            return found;
        }

        public override int parameters()
        {
            return 1;
        }

        public override void set(string name,int value)
        {
            if (checkFor(name))
            {
                this.varName[varCount] = name;
                this.varValue[varCount++] = value;
            }
        }
    }
}
