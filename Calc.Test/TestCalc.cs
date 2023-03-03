using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calc.Test
{
    [TestFixture]
    internal class TestCalc
    {

        [SetUp]
        public void Init()
        {
            // Initialize before all Tests
        }


        [Test, Order(2), Category("This is my Test")] // Order => in which order the test function will run. Category => puts the test function in a category
        public void RunTest1()
        {
            int a = 10;
            int b = 10;

            Assert.AreEqual(a, b);
        }


        [Test, Order(1), Ignore("Have not finished yet")] // Ignore => ignores the test function, will not run it
        public void RunTest2()
        {
            int a = 10;
            int b = 11;
            int c = a + b;
            Calculation calculation = new Calculation();

            Assert.That(calculation.Plus(a, b), Is.InRange(10, 1000));
            Assert.That(calculation.Plus(a, b), Is.LessThan(800));
            Assert.AreEqual(c, calculation.Plus(a, b));
        }


        [Test]
        public void RunTest3()
        {
            int a = 10;
            int b = 10;
            int c = a - b;
            Calculation calculation = new Calculation();

            Assert.AreEqual(c, calculation.Minus(a, b));
        }


        [Test]
        public void RunTest4()
        {
            int a = 10;
            int b = 10;
            int c = a * b;
            Calculation calculation = new Calculation();

            Assert.AreEqual(c, calculation.Mult(a, b));
        }



        [Test]
        public void RunTest5()
        {
            int a = 10;
            int b = 10;
            int c = a / b;
            Calculation calculation = new Calculation();

            Assert.AreEqual(c, calculation.Div(a, b));
        }


        //--------------------------------------------------------//
        public void RunTest6(int a, int b)
        {
            int c = a + b;
            Calculation calculation = new Calculation();


            Assert.AreEqual(c + 2, calculation.Plus(a, b));
        }

        [Test]
        public void RunTest7()
        {
            for (int i = 0; i < 10; i++)
            {
                RunTest6(i, i);
            }

        }
    }
}
