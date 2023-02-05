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

            if (checkFor(form, name).Equals(null))
            {
                form.varName.Add(name);
                form.varValue.Add(0);
            }
           // ProgramLangEnvironment.Parser form = form;
        }

        public override void execute()
        {
            //decide if it's set or declare
            declare();
        }
        public override int? checkFor(Form1 form, string param)
        {
           

            if (form.varName.Contains(param))
            { found = form.varName.FindIndex(a => a.Contains(param)); }
            if (found == -1) { found = null; return found; }
            return found;
        }

        public override int parameters()
        {
            return 1;
        }
        public void setVal(string name, int value)
        {
            int? a = checkFor(form, name);
            if (a>= 0)
            {
                this.value = value;
                form.varValue[(int)a]=(value);
            }
        }

        public override void set(Form1 form, string name)
        {
            this.form = form;
            this.name = name;
        }
    }
}
