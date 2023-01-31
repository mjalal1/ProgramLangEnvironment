using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramLangEnvironment
{
    class Parser 
    {    // I want a ParseProgram for pw and a ParseLine for the line at hand
        Form1 form;
        public Parser(Form1 form)
        {
            this.form = form;
        }
       
      
        /// <summary>
        /// This function parses the string given to it, splits it into command and parameters, and decides which function to call.
        /// Exceptions are mostly thrown here
        /// </summary>
        /// <param name="line"> The command and parameters passed by the user </param>
        public void ParseCommand(String line)
        {

            line = line.Trim().ToLower();  //trim excess and bring everything into same case 
            string[] comLine = line.Split('\n'); //Splits on new line, splits program into different lines
            ParseLine(comLine);

        }


        private void ParseLine(string[] comLine)
        {
            for (int x = 0; x < comLine.Length; x++) // Iterate on every line of code stored
            {
                string[] com = comLine[x].Split(' ');   //Split into command and parameters
                string command = com[0]; //Assign command to a variable           
                List<int> Param = new List<int>(); // Create list of integers to store parameters after conversion

                if (com.Length > 1) // if there are parameters
                {
                    string[] Params = com[1].Split(','); //Split whole parameter into array of parameter strings

                    foreach (string i in Params) // Iterate through each parameter in string form and convert to int
                    {
                        int a; // Variable to hold integer output
                        try
                        {
                            int.TryParse(i, out a);// TryParse the string as int - surround with try catch
                            Param.Add(a);//Add int to list of parameters
                        }
                        catch (Exception ex)
                        {
                            throw new ApplicationException("Invalid Parameters ");
                        }
                    }
                }

                ShapeFactory sf = new ShapeFactory();
                if (command=="circle")
                {
                    if ((Param.Count() != 1) || (Param[0] == 0))
                    {

                        throw new ApplicationException("Invalid Parameters : Circle takes 1 parameter: radius");
                    }
                    Circle c = (Circle)sf.GetCmd(command);
                    c.set(form.Canvas.Pen.Color, Param[0]);
                    c.execute(form.Canvas);
                }      
                else if (command == "rect")
                {
                    if ((Param.Count() != 2) || (Param.Contains(0)))
                    {

                        throw new ApplicationException("Invalid Parameters : Rect takes 2 parameters: length and height");
                    }
                    Rect c = (Rect)sf.GetCmd(command);
                    c.set(form.Canvas.Pen.Color, Param[0],Param[1]);
                    c.execute(form.Canvas);

                }

                else // If this is reached, the command given was not any of the accepted commands
                {
                    throw new ApplicationException("Command not recognised\nValid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");

                }
            }
        }







    }
}


