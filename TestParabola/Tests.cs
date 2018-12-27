using System;
using NUnit.Framework;

namespace ControlWork
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Input_Zero_Values()
        {
            Parabola Parabola = new Parabola(0, 0, 0);
            Parabola.Output();
            Assert.True(true);
        }

        [Test]
        public void Input_Negative_Values()
        {
            Parabola Parabola = new Parabola(-2, -3, -4);
            Parabola.Output();
            Assert.True(true);
        }

        [Test]
        public void Input_Positive_Values()
        {
            Parabola Parabola = new Parabola(3, 4, 5);
            Parabola.Output();
            Assert.True(true);
        }
    }
}