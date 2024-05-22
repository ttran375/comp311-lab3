using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace comp311_lab3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            // Create an instance to test:
            Rooter rooter = new Rooter();

            // Define a test input and output value:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;

            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);

            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }
}
