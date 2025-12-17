using System;
using NUnit.Framework;
using Zadanie;

namespace Zadanie.Test
{
    public class Program
    {
        private Wpisy _wpis;

        [SetUp]
        public void SetUp()
        {
            _wpis = new Wpisy();
        }

        [Test]
        public void Test_czy_10_liter()
        {
            string tekst = "1234567890";
            string result = "10 liter";

            string act = _wpis.sprawdzenie10liter(tekst);

            Assert.That(act, Is.EqualTo(result));
        }
        [Test]
        public void Test_czy_10_20_liter()
        {
            string tekst = "1234567890123";
            string result = "1020 liter";

            string act = _wpis.sprawdzenie10_20liter(tekst);

            Assert.That(act, Is.EqualTo(result));
        }
        [Test]
        public void Test_czy_zwraca_string()
        {
            string tekst = "1234567890";
            string result = "string instance";

            string act = _wpis.sprawdzCzyString(tekst);

            Assert.That(act, Is.EqualTo(result));
        }
        [Test]
        public void Test_czy_zwraca_int()
        {
            string tekst = "1234567890";
            string result = "int instance";

            string act = _wpis.sprawdzCzyInt(tekst);

            Assert.That(act, Is.EqualTo(result));
        }
    }
}