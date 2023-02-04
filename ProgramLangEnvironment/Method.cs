using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class Method : Declarations
    {
         int? found=null;
        string name;
        int location;
        public override int? checkFor(Parser p,string param)
        {
            this.p = p;
         
            if (p.methName.Contains(param))
            { found = p.methName.FindIndex(a => a.Contains(param)); }
            return found;
        }

        public override void declare() // call method. takes same params 
        {
           if (checkFor(p,name)>=0)
            {
                p.svprogramCounter = p.programCounter+1; //// needs attention, parameters wise
                p.programCounter = p.methLoc[(int)found];
            }
        }

        public override void execute()
        {
            throw new NotImplementedException();
        }

        public override int parameters()
        {
            return 1;
        }
       
       
        public  void set(Parser p,string name, int value)
        {
            this.p = p;
            this.name = name;
            this.location = value;
            if (checkFor(p,name)>=0)
            {
                p.methName.Add(name);
                p.methLoc.Add(value);
            }
        }

        public override void set(Parser p, string name)
        {
            throw new NotImplementedException();
        }
    }
}
