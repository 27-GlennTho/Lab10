using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;
        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestPWR()
        {
            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(7, 2, "-");
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(4, 3, "*");
            Assert.AreEqual(result, 12);
        }
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(15, 3,"/");
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void TestSQRT()
        {
            result = Calculator.CalculatePair(16,1, "SQRT");
            Assert.AreEqual(result, 4);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestSuiteWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
