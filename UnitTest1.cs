using System;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("inside setup");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("inside Test1");

            Assert.Pass();
        }

         [Test]
        public void Test2()
        {
            Console.WriteLine("inside Test2");

            Assert.Pass();
        }


         [Test]
        public void Test3()
        {
            Console.WriteLine("inside Test1");

            Assert.Pass();
        }

         [Test]
        public void Test4()
        {
            Console.WriteLine("inside Test1");

            Assert.Pass();
        }
    }
}