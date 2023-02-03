using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLangEnvironment
{
  public  abstract class Command : ICommand
    {

   public abstract int parameters();
        public abstract void execute();
        public abstract string cmdType();
      //  public abstract void set(params dynamic[] list);
    }
}
