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
        public List<string> varName = new List<string>();
        public List<int> varValue = new List<int>();
        public List<string> methName = new List<string>();
        public List<int> methLoc = new List<int>();
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
            
            programWindow.Text = File.ReadAllText(path+".txt");

        }

         /// <summary>
         /// This function parses the string given to it, splits it into command and parameters, and decides which function to call.
         /// Exceptions are mostly thrown here, should be refactored to a seperate class
         /// </summary>
         /// <param name="line"> The command and parameters passed by the user </param>
       




        public void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Enter)
            {

                Parser p = new Parser(this);
                p.ParseProgram(commandLine.Text);
                
            
                Refresh();
            }

        }
    }
}
