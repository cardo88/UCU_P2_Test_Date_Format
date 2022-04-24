using NUnit.Framework;
using DateFormat;

namespace DataFormat.test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            const string datoenviado = "10/11/1977";
            const string datoesperado = "1977-11-10";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test2()
        {
            const string datoenviado = "01/01/0011";
            const string datoesperado = "0011-01-01";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test3()
        {
            const string datoenviado = "dd/mm/aaaa";
            const string datoesperado = "aaaa-mm-dd";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }
    }
}