using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLangEnvironment
{
    class Save : StoreCmd
    {

        public Save() : base()
        { }



        public void set(Form1 form, string filepath)
        {
            this.form = form;
            this.filePath = filepath;
        }
        public override string ToString()
        {
            return "Save";
        }
        public override int parameters()
        {
            return 0;
        }
        public override void execute()
        {

            File.WriteAllText(filePath + ".txt", form.programWindow.Text);

        }
    }
}
