using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLangEnvironment
{
    class Load : StoreCmd
    {
      
        public Load() : base()
        { }


    
        public void set(Form1 form,string filepath)
        {
            this.form = form;
            this.filePath = filepath;
        }
        public override string ToString()
        {
            return "Load";
        }
        public override int parameters()
        {
            return 1;
        }
        public override void execute()
        {
           
            form.programWindow.Text = File.ReadAllText(filePath + ".txt");

        }
    }
}
