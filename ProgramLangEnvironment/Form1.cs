using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgramLangEnvironment
{
    public partial class Form1 : Form
    {
        const int bmpx = 640;
        const int bmpy = 480;

      public  Bitmap OutBmp = new Bitmap(bmpx, bmpy);
      public  CanvasO Canvas;
        public Form1()
        {
            InitializeComponent();
            Canvas = new CanvasO(Graphics.FromImage(OutBmp));
        }

        private void commandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            // wrong event called . breaks everything when removed. dont remove
        }
         
        ///Updates the bmp when paint event occurs
        private void outputWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutBmp, 0, 0);
        }

        /// <summary>
        /// Saves the program currently in the programWindow to a text file of given name
        /// </summary>
        /// <param name="path">Name to be given to the file</param>
        public void Save(String path)
        {
            File.WriteAllText(path + ".txt", programWindow.Text);
        }

        /// <summary>
        /// Loads a program from a file (located in source/repos/) and stores it in the programWindow
        /// </summary>
        /// <param name="path">Name of the file to load from</param>
        public void LoadFile(String path)
        {
            string FileText= File.ReadAllText(path+".txt");
            programWindow.Text = FileText;

        }

         /// <summary>
         /// This function parses the string given to it, splits it into command and parameters, and decides which function to call.
         /// Exceptions are mostly thrown here, should be refactored to a seperate class
         /// </summary>
         /// <param name="line"> The command and parameters passed by the user </param>
        public void ParseCommand(String line)
        {

            line = line.Trim().ToLower();  //trim excess and bring everything into same case 
            string[] comLine = line.Split('\n'); //Splits on new line, splits program into different lines
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
                            throw new ApplicationException("Invalid Parameters : drawTo takes 2 parameters : x and y");
                        }

                         
                    }



                }

                if (command.Equals("drawto"))
                {
                    if (Param.Count() == 2) // Checks it has expected number of params
                    {
                        if (Param[0] == 0) // if the value stored is 0, the parameter given was not a valid parameter as it didnt reach this array.
                        {
                            throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters :(int) x and y");
                        }

                        Canvas.DrawTo(Param[0], Param[1]);
                        //    throw new ApplicationException("Params are " + Param[0] + Param[1]);



                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : drawTo takes 2 parameters : x and y");
                    }
                }



                if (command.Equals("moveto"))
                {
                    if (Param.Count() == 2)
                    {
                        if (Param[0]==0)
                        {
                            throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters :(int) x and y");
                        }
                        Canvas.MoveTo(Param[0], Param[1]);
                        Debug.WriteLine("x is " + Param[0] + ". y is " + Param[1]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters : x and y");
                    }
                }

                else if (command.Equals("rect"))
                {
                    if (Param.Count() == 2)
                    {
                        if (Param[0] == 0)
                        {
                            throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters :(int) x and y");
                        }
                        Canvas.DrawRect(Param[0], Param[1]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Rect takes 2 parameters : length and height");
                    }

                }
                else if (command.Equals("circle"))
                {
                    if (Param.Count() == 1)
                    {
                        if (Param[0] == 0)
                        {
                            throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters :(int) x and y");
                        }
                        Canvas.DrawCircle(Param[0]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Circle takes 1 parameter: radius");
                    }
                }
                else if (command.Equals("triangle"))
                {
                    if (Param.Count() == 6)
                    {

                        Canvas.DrawTriangle(Param[0], Param[1], Param[2], Param[3], Param[4], Param[5]);


                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Triangle takes 6 parameters : x1 and y1, x2 and y2, x3 and y3");
                    }
                }
                else if (command.Equals("clear"))
                {
                    Canvas.clear();
                }
                else if (command.Equals("reset"))
                {
                    Canvas.reset();
                }
                else if (command.Equals("save"))
                {
                    if (com.Length > 1)
                    {
                        Save(com[1]); // Parameters are string so com[] is used instead as parameters are still in string form here
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Save takes 1 parameter: filename");
                    }
                }

                else if (command.Equals("load"))
                {
                    if (com.Length > 1)
                    {
                        LoadFile(com[1]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Load takes 1 parameter: filename");
                    }
                }
                else if (command.Equals("pen"))
                {
                    if (com.Length > 1)
                    {

                        Canvas.pen(com[1]);
                        Console.WriteLine(com[1]);

                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : pen takes 1 parameter: colour (red/blue/green/pink/purple/black) ");
                    }
                }
                else if (command.Equals("fill"))
                {
                    if (com.Length > 1)
                    {
                        if (com[1] == "on" || com[1] == "off") // Hard coded as it seemed like simplest option
                        {
                            Canvas.fill(com[1]);
                            Console.WriteLine(com[1]);
                        }
                        else
                        {
                            throw new ApplicationException("Invalid Parameters : fill takes 1 parameter: on/off ");
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : fill takes 1 parameter: on/off ");
                    }
                }

                else if (command.Equals("run"))
                {
                    ParseCommand(programWindow.Text); // To run pW code, parseCommand is called recursively on the pw.Text
                }


                else // If this is reached, the command given was not any of the accepted commands
                {
                    throw new ApplicationException("Command not recognised\nValid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");
                  
                }

            }

        }




        public void commandLine_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ParseCommand(commandLine.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex.Message); // Exception is shown to user here. 
                }
                Refresh();
            }

        }
    }
}
