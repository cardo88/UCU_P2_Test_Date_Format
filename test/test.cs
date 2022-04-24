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
        public void Test1() //verifica que funcione normal
        {
            const string datoenviado = "10/11/1977";
            const string datoesperado = "1977-11-10";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test2()  //verfica que funcione con ceros al principio
        {
            const string datoenviado = "01/01/0011";
            const string datoesperado = "0011-01-01";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test3() //verifica si se ingresan letras, que se devuelvan en el orden esperado
        {
            const string datoenviado = "xx/oo/abcd";
            const string datoesperado = "abcd-oo-xx";
            Assert.AreEqual(Program.ChangeFormat(datoenviado),datoesperado);
        }


                [Test]
        public void Test4() //verifica que funcione normal
        {
            const string datoenviado = "10/11/1977";
            const string datoesperado = "10-11-1977";
            Assert.AreEqual(Program.OtherChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test5() //verfica que funcione con ceros al principio
        {
            const string datoenviado = "01/01/0011";
            const string datoesperado = "01-01-0011";
            Assert.AreEqual(Program.OtherChangeFormat(datoenviado),datoesperado);
        }
        
        [Test]
        public void Test6() //verifica si se ingresan letras, que se devuelvan en el orden esperado
        {
            const string datoenviado = "xx/oo/abcd";
            const string datoesperado = "xx-oo-abcd";
            Assert.AreEqual(Program.OtherChangeFormat(datoenviado),datoesperado);
        }
    }
}