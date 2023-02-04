using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProgramLangEnvironment
{ 
  class ConditionalCmd : Command
    {
        public String expression;
        DataTable dt = new DataTable();

        public override string cmdType()
        {
            return "Conditional";
        }

        public override void execute()
        {
            throw new NotImplementedException();
        }

        public override int parameters()
        {
            throw new NotImplementedException();
        }

        public object validate(String expression)
        {
          var result=  dt.Compute(expression, "");
            return result;
        }

    }
}
