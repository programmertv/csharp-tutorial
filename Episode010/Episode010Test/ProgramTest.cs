using System;
using System.Linq;
using Episode010;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Episode010Test
{
    [TestClass]
    public class UnitTest1
    {
        private SampleComputation sample;
        [TestInitialize]
        public void Init()
        {
            sample = new SampleComputation();
        }

        [DataRow(1, 1, SampleOperator.Add, 2)]
        [DataRow(1, 5, SampleOperator.Add, 6)]
        [DataRow(10, 5, SampleOperator.Divide, 2)]
        [DataRow(100, 10, SampleOperator.Divide, 10)]
        [DataTestMethod]
        public void SampleComputationTest(int num1, int num2, SampleOperator op, int expected)
        {
            Assert.AreEqual(sample.Compute(num1, num2, op), expected);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void SampleDivideByZeroError()
        {
            sample.Compute(1, 0, SampleOperator.Divide);
        }

        [TestMethod]
        public void BinaryTest()
        {
            var binary255 = "11111111";
            var binary255Result = Program.GetBitValues(binary255).Sum();
            Assert.AreEqual(255, binary255Result);

            var binary15 = "00001111";
            var binary15Result = Program.GetBitValues(binary15).Sum();
            Assert.AreEqual(15, binary15Result);
        }

    }
}
