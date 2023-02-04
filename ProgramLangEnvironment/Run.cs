using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
    class Run : Declarations
    {
        Parser p;
        Form1 forma;
        public override void execute()
        {
              p.ParseProgram(p.form.programWindow.Text);
            
            forma.Refresh();
        }

        public void run()
        {
          
            //
        }
        public void set(Form1 form)
        {
            this.p = new Parser(form);
            this.forma = form;
     
        }
        public override int parameters()
        {
            return 0;
        }

        public override void set(Parser p, string name)
        {  
            throw new NotImplementedException();
        }

        public override void declare()
        {
            throw new NotImplementedException();
        }

        public override int? checkFor(Parser p, string param)
        {
            throw new NotImplementedException();
        }
    }
}
