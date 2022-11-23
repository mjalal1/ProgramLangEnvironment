using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgramLangEnvironment;
using System.Drawing;

namespace PLEUnitTesting
{
    [TestClass]
    public class PLEUnitTests
    {
        [TestMethod]
        public void TestMoveToValid()
        {
            Form1 forma = new Form1();
              forma.ParseCommand("moveto 100,150");
            Assert.AreEqual(100, forma.Canvas.posx,0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);

        }


        [TestMethod]
        public void TestMoveToInvalid()
        {
            Form1 forma = new Form1();
            forma.ParseCommand("moveto 100");
            Assert.AreNotEqual(100, forma.Canvas.posx, 0.01);
           

        }

        [TestMethod]
        public void TestInvalidCommand()
        {
            Form1 forma = new Form1();
            forma.ParseCommand("abcdef 100");
            Assert.


        }
    }
}
