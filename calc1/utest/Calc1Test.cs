using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace calc1
{
    [TestFixture]
    public class Calc1Test
    {
        [Test]
        public void CalcSumTest()
        {
            Assert.AreEqual(5, Calc1.Calculate(2,3,'+'));
        }

        [Test]
        public void CalcMulTest()
        {
            Assert.AreEqual(15, Calc1.Calculate(5, 3, '*'));
        }
        
        [Test]
        public void CalcSubTest()
        {
            Assert.AreEqual(2, Calc1.Calculate(5, 3, '-'));
        }
        
        [Test]
        public void CalcDivTest()
        {
            Assert.AreEqual(2, Calc1.Calculate(6, 3, '/'));
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalcDivNullTest()
        {
            Calc1.Calculate(6, 0, '/');
        }
        
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalcWrongOperandTest()
        {
            Calc1.Calculate(6, 3, '!');
        }
    }
}
