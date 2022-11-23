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
            Assert.AreEqual(100, forma.Canvas.posx, 0.01);
            Assert.AreEqual(150, forma.Canvas.posy, 0.01);

        }


        [TestMethod]
        public void TestMoveToInvalid()
        {
            Form1 forma = new Form1();
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand("moveto 100"));


        }

        [TestMethod]
        public void TestInvalidCommand()
        {
            Form1 forma = new Form1();
            string a = "abcdef 100";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }

        [TestMethod]
        public void TestInvalidParameters()
        {
            Form1 forma = new Form1();
            string a = "circle bogey";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }
        [TestMethod]
        public void TestParseCommand()
        {
            Form1 forma = new Form1();
            string a = "Giggs better pop up in ur thoughts as an artist\nJheeze Holl3rin at man";
            Assert.ThrowsException<ApplicationException>(() => forma.ParseCommand(a));
        }
    }
}
