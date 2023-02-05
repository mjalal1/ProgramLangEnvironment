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
        public override int? checkFor(Form1 form,string param)
        {
            this.form = form;
         
            if (form.methName.Contains(param))
            { found = form.methName.FindIndex(a => a.Contains(param)); }
            return found;
        }

        public override void declare() // call method. takes same params 
        {
           if (checkFor(form,name)>=0)
            {
               // form.svprogramCounter = form.programCounter+1; //// needs attention, parameters wise
              //  form.programCounter = form.methLoc[(int)found];
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
       
       
        public  void set(Form1 form,string name, int value)
        {
            this.form = form;
            this.name = name;
            this.location = value;
            if (checkFor(form,name)>=0)
            {
                form.methName.Add(name);
                form.methLoc.Add(value);
            }
        }

        public override void set(Form1 form, string name)
        {
            throw new NotImplementedException();
        }
    }
}
