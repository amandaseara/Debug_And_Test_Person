using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void TestTodoBien()
        {
            Person julia = new Person("Julia Rodriguez", "9.999.999-9");
            string res = $"Soy {julia.Name} y mi cédula es {julia.ID}";

            Assert.AreEqual("Soy Julia Rodriguez y mi cédula es 9.999.999-9",res);
        }

        [Test]
        public void TestNombreMal()
        {
            Person julia = new Person("", "9.999.999-9");
            string res = $"Soy {julia.Name} y mi cédula es {julia.ID}";

            Assert.AreEqual("Soy  y mi cédula es 9.999.999-9",res);
        }

        [Test]
        public void TestIdMal()
        {
            Person julia = new Person("Julia Rodriguez", "1.234.567-8");
            string res = $"Soy {julia.Name} y mi cédula es {julia.ID}";

            Assert.AreEqual("Soy Julia Rodriguez y mi cédula es ",res);
        }

        [Test]
        public void TestTodoMal()
        {
            Person julia = new Person("", "1.234.567-8");
            string res = $"Soy {julia.Name} y mi cédula es {julia.ID}";

            Assert.AreEqual("Soy  y mi cédula es ",res);
        }

    }
}