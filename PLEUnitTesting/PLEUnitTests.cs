using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgramLangEnvironment;
using System.Drawing;

namespace PLEUnitTesting
{
    [TestClass]
    
    public class PLEUnitTests
    { 
        /// <summary>
        /// Tests for the PLE. Currently test the moveTo command, the parseCommand() function.
        /// </summary>

        [TestMethod]
        /// <summary>
        /// Test method to test if moveTo executes with valid parameters. Checks that x position and y position are the expected values
        /// </summary>
        public void TestMoveToValid()
        {
            Form1 forma = new Form1();
            forma.ParseCommand("moveto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);

        }

     
        [TestMethod]
           /// <summary>
        /// Tests moveTo command with invalid parameters. Checks for an expected exception, Application Ex.
        /// </summary>
        public void TestMoveToInvalid()
        {
            Form1 forma = new Form1();
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand("moveto 100"));


        }
        /// <summary>
        /// Tests the parseCommand() when given an invalid command. Checks for ApplicationException thrown
        /// </summary>
        [TestMethod]
        public void TestInvalidCommand()
        {
            Form1 forma = new Form1();
            string a = "abcdef 100";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }


        /// <summary>
        /// Tests the parseCommand() when given an invalid parameter. Checks for ApplicationException thrown
        /// </summary>
        [TestMethod]
        public void TestInvalidParameters()
        {
            Form1 forma = new Form1();
            string a = "circle bogey";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }


        [TestMethod]

        /// <summary>
        /// Tests the parseCommand() when given an invalid string. Checks for ApplicationException thrown
        /// </summary>
        public void TestParseCommand()
        {
            Form1 forma = new Form1();
            string a = "Giggs better poist\n Holl3rin at man";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }

        // [PART 2 TESTS]
        public void TestFactory()
        {
            Form1 forma = new Form1();
            var sf = new ShapeFactory();
            Object o = (Object)sf.GetCmd("invalid");
            Assert.ThrowsException<ApplicationException>(() => sf.GetCmd(o.ToString()));
        }

        public void TestParserClass()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            string a = "circle bogey";
            Assert.ThrowsException<ApplicationException>(() => p.ParseProgram(a));
        }

        public void TestWhile()
        {
            Form1 forma = new Form1();
            Parser p = new Parser(forma);
            string a = "while x>10\ncircle x\nx=x+1\nendwhile";
            Assert.ThrowsException<ApplicationException>(() => p.ParseProgram(a));
        }


    }
}
