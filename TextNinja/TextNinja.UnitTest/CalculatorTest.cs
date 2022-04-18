using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TextNinja.UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CheckCalculator()
        {
            var calculator = new Calculator();
            int result = calculator.Add(4, 3);
            Assert.AreEqual(7, result);
            Assert.AreNotEqual(0, result);
            
        }

        
    } 
}
