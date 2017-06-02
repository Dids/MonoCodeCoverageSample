using System;
using NUnit.Framework;

namespace ConsoleApp
{
    public class ConsoleApp
    {
        public static int Main(string[] args = null)
        {
            Console.WriteLine("Main()");

            Something();
            SomethingMore();
            SomethingUntested();

            return 0;
        }

        public static int Something()
        {
            Console.WriteLine("Something()");
            return 1;
        }

        public static bool SomethingMore()
        {
            Console.WriteLine("SomethingMore()");
            return true;
        }

        public static bool SomethingUntested()
        {
            Console.WriteLine("SomethingUntested()");
            return false;
        }
    }
}

namespace ConsoleApp.UnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestMain()
        {
            Console.WriteLine("TestMain()");
            var result = ConsoleApp.Main();
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestSomething()
        {
            Console.WriteLine("TestSomething()");
            var result = ConsoleApp.Something();
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TestSomethingMore()
        {
            Console.WriteLine("TestSomethingMore()");
            var result = ConsoleApp.SomethingMore();
            Assert.AreEqual(result, true);
        }
    }
}
