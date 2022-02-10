using NetCoreConsole;
using NUnit.Framework;

namespace UnitTest.NetCoreConsole
{
    [TestFixture]
    internal class UnitTests
    {
        [TestCase(5, 6, 11)]
        [TestCase(3, 10, 13)]
        [TestCase(50, 20, 70)]
        [TestCase(300, 100, 400)]
        [TestCase(200, 360, 560)]
        public void Add_Operations_Success(int a, int b, int expected)
        {
            int result = Program.AddNumbers(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 6, 12)]
        [TestCase(3, 10, 33)]
        [TestCase(50, 20, 530)]
        [TestCase(300, 100, 3400)]
        [TestCase(200, 360, 5560)]
        public void Add_Operations_Fail(int a, int b, int expected)
        {
            int result = Program.AddNumbers(a, b);
            Assert.That(result, Is.Not.EqualTo(expected));
        }

        [TestCase(5, 6, -1)]
        [TestCase(3, 10, -7)]
        [TestCase(50, 20, 30)]
        [TestCase(300, 100, 200)]
        [TestCase(200, 360, -160)]
        public void Substract_Operations_Success(int a, int b, int expected)
        {
            int result = Program.SubstractNumbers(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 6, 12)]
        [TestCase(3, 10, 33)]
        [TestCase(50, 20, 530)]
        [TestCase(300, 100, 3400)]
        [TestCase(200, 360, 5560)]
        public void Substract_Operations_Fail(int a, int b, int expected)
        {
            int result = Program.SubstractNumbers(a, b);
            Assert.That(result, Is.Not.EqualTo(expected));
        }

        [TestCase(5, 6, 30)]
        [TestCase(4, 10, 40)]
        [TestCase(50, 20, 1000)]
        [TestCase(300, 100, 30000)]
        [TestCase(200, 360, 72000)]
        public void Multiply_Operations_Success(int a, int b, int expected)
        {
            int result = Program.MultiplyNumbers(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 6, 12)]
        [TestCase(3, 10, 33)]
        [TestCase(50, 20, 530)]
        [TestCase(300, 100, 3400)]
        [TestCase(200, 360, 5560)]
        public void Multiply_Operations_Fail(int a, int b, int expected)
        {
            int result = Program.MultiplyNumbers(a, b);
            Assert.That(result, Is.Not.EqualTo(expected));
        }

        [TestCase(4, 2, 2)]
        [TestCase(25, 5, 5)]
        [TestCase(60, 3, 20)]
        [TestCase(500, 2, 250)]
        [TestCase(80, 20, 4)]
        public void Divide_Operations_Success(int a, int b, int expected)
        {
            int result = Program.DivideNumbers(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 6, 12)]
        [TestCase(3, 10, 33)]
        [TestCase(50, 20, 530)]
        [TestCase(300, 100, 3400)]
        [TestCase(200, 360, 5560)]
        public void Divide_Operations_Fail(int a, int b, int expected)
        {
            int result = Program.DivideNumbers(a, b);
            Assert.That(result, Is.Not.EqualTo(expected));
        }
    }
}