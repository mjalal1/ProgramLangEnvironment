using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Diagnostics;

namespace ProgramLangEnvironment
{
    public class Parser
    {
        public Form1 form;
        public int programCounter = 0;
        public int svprogramCounter;
        public int methodCount;
        public int varCount;
        public List<string> varName = new List<string>();
        public List<int> varValue = new List<int>();
        public List<string> methName = new List<string>();
        public List<int> methLoc = new List<int>();
        public Parser(Form1 form)
        {
            this.form = form;
        }


        /// <summary>
        /// This function parses the string given to it, splits it into command and parameters, and decides which function to call.
        /// Exceptions are mostly thrown here
        /// </summary>
        /// <param name="line"> The command and parameters passed by the user </param>
        public void ParseProgram(String line)
        {

            line = line.Trim().ToLower();  //trim excess and bring everything into same case 
            string[] comLine = line.Split('\n'); //Splits on new line, splits program into different lines
            ParseLine(comLine[programCounter]);
            programCounter++;

        }


        private void ParseLine(string comLine)
        {
            for (int i = 0; i <= comLine.Length; i++)
            {


                string[] com = comLine.Split(' ');   //Split into command and parameters
                string command = com[0]; //Assign command to a variable           
                List<int> Param = new List<int>(); // Create list of integers to store parameters after conversion

                if (com.Length > 1) // if there are parameters
                {
                    string[] Params = com[1].Split(','); //Split whole parameter into array of parameter strings

                    foreach (string x in Params) // Iterate through each parameter in string form and convert to int
                    {
                        //int a; // Variable to hold integer output
                        try
                        {
                            int.TryParse(x, out int a);// TryParse the string as int - surround with try catch
                            Param.Add(a);//Add int to list of parameters
                        }
                        catch (Exception)
                        {
                            throw new ApplicationException("Invalid Parameters ");
                        }
                    }
                }


                if (command.Equals("run"))
                {
                    ParseProgram(form.programWindow.Text);
                    continue;// To run pW code, parseCommand is called recursively on the pw.Text
                }
                if (com[1].Equals("="))
                {
                    ShapeFactory sf2 = new ShapeFactory();  // move to inside for loop ~39, if cmdType=draw do int param, if =declare nest if com[1] is = then set execute, if com[1]
                    dynamic c2 = sf2.GetCmd(com[1]);
                    
                    continue;// To run pW code, parseCommand is called recursively on the pw.Text
                }

                ShapeFactory sf = new ShapeFactory();  // move to inside for loop ~39, if cmdType=draw do int param, if =declare nest if com[1] is = then set execute, if com[1]
                dynamic c = sf.GetCmd(command);
                if ((Param.Count() != c.parameters()) || (Param.Contains(0))) // ! check for zero doesnt work for string paramets 
                {

                    // throw new ApplicationException("Invalid Parameters : " + c.ToString() + " takes " + c.parameters() + " parameter(s)");
                }

                if (c.cmdType() == "Draw")
                {
                    if ((Param.Count() != c.parameters()) || (Param.Contains(0))) // ! check for zero doesnt work for string paramets 
                    {
                        throw new ApplicationException("Invalid Parameters : " + c.ToString() + " takes " + c.parameters() + " parameter(s)");
                    }
                    c.set(form.Canvas, Param.ToArray());
                    c.execute();

                }
                else if (c.cmdType() == "Store")
                {
                    if ((Param.Count() != c.parameters())) // ! check for zero doesnt work for string paramets 
                    {
                        throw new ApplicationException("Invalid Parameters : " + c.ToString() + " takes " + c.parameters() + " parameter(s)");
                    }
                    c.set(form, com[1]);
                    c.execute();
                }
                else if (c.cmdType() == "Conditional")
                {
                    if ((Param.Count() != c.parameters())) // ! check for zero doesnt work for string paramets 
                    {
                        throw new ApplicationException("Invalid Parameters : " + c.ToString() + " takes " + c.parameters() + " parameter(s)");
                    }
                    c.validate();
                }
                else if (c.cmdType() == "Declare")
                {
                    if ((Param.Count() != c.parameters())) // ! check for zero doesnt work for string paramets 
                    {
                        throw new ApplicationException("Invalid Parameters : " + c.ToString() + " takes " + c.parameters() + " parameter(s)");
                    }
                    if (com.Length > 1)
                    {
                        if (com[1] == "=")
                        {
                            c.set(this, command, com[2]);
                            c.execute();
                        }
                    }

                    if (command == "call")
                    {
                        c.declare(this, com[1]);
                        c.execute();

                    }
                    else if (command == "method")
                    {
                        c.set(this, com[1], programCounter);
                        c.execute();
                    }
                    else if (command == "var")
                    {
                        c.set(this, com[1]);
                       
                        c.execute();
                    }
                    else if (command == "run")
                    {
                        c.set(this.form);
                        c.execute();
                    }


                }
            }
            //     c.execute();

        }

    }







}


