using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace nunit_error
{
    [TestFixture]
    public class Tests
    {
        private class TestCases
        {
            private static IEnumerable<TestCaseData> TestData
            {
                get
                {
                    yield return new TestCaseData("Test 1").SetName("Test 1");
                    yield return new TestCaseData("Test 2").SetName("Test 2");
                    yield return new TestCaseData("Test 3").SetName("Test 3");
                    yield return new TestCaseData("Test 4").SetName("Test 4");
                    yield return new TestCaseData("Test 5").SetName("Test 5");
                }
            }
        }

        [SetUp]
        public void Setup()
        {
            //
        }

        [TestCaseSource(typeof(TestCases), "TestData")]
        public void Test(string data)
        {
            Console.WriteLine(data);
        }
    }
}