﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramLangEnvironment
{
    public partial class Form1 : Form
    {
        const int bmpx = 640;
        const int bmpy = 480;
        Bitmap OutBmp = new Bitmap(bmpx, bmpy);
        CanvasO Canvas;
        public Form1()
        {
            InitializeComponent();
            Canvas = new CanvasO(Graphics.FromImage(OutBmp));
        }

        private void commandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void outputWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutBmp, 0, 0);
        }

      
            public void ParseCommand(String line)
            {
               
                line = line.Trim().ToLower();  //trim excess and bring everything into same case
               string[] com = line.Split(' ');   //Split into command and parameters
                string command = com[0]; //Assign command to a variable
                string Params = com[1]; // Assign chunk of whole parameter to a string to further split
                string[] ParamL = Params.Split(','); //Split whole parameter string into array of parameter strings
                List<int> Param = new List<int>(); // Create list of integers to store parameters after conversion

                foreach (string i in ParamL) // Iterate through each parameter in string form and convert to int
                {
                    int a; // Variable to hold integer output
                    int.TryParse(i, out a); // TryParse the string as int - surround with try catch
                    Param.Add(a); //Add int to list of parameters
                }


            if (command.Equals("drawto"))
            {
                if (Param.Count() == 2)
                {


                    Canvas.DrawTo(Param[0], Param[1]);
                    MessageBox.Show("Params are " + Param[0] + Param[1]);
                    Console.WriteLine("Line drew");


                }
                else
                {
                    MessageBox.Show("Invalid Parameters : drawTo takes 2 parameters : x and y");
                }
            }

                else if (command.Equals("rect"))
                    {
                        Canvas.DrawRect(Param[0], Param[1]);
                        Console.WriteLine("Square drew");
                    }
            else if (command.Equals("circle"))
            {
                Canvas.DrawCircle(Param[0]);

            }
            }
        


        public void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
        
            if (e.KeyCode == Keys.Enter)
            {
                ParseCommand(commandLine.Text);
   Refresh();
            }
         
        }
    }
}
