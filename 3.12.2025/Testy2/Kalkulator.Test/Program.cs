using System;
using NUnit.Framework;
using Kalkulator;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Kalkulator.Test
{
    internal class Test
    {

            private Program _kalkulator;

            [SetUp]

            public void SetUp()
            {
                _kalkulator = new Program();
            }

            [Test]
            public void Dodawanie_powinna_zwrocic_sume_a_i_b()
            {
                //aaa
                //Arrange
                double a = 10;
                double b = 5;
                double result = 15;

                //act
                double act = _kalkulator.dodawanie(a, b);

                //Assert
                Assert.That(act, Is.EqualTo(result));
            }
            [Test]
            public void Odejmowanie_powinna_zwrocic_sume_a_i_b()
            {
                //aaa
                //Arrange
                double a = 10;
                double b = 5;
                double result = 5;

                //act
                double act = _kalkulator.odejmowanie(a, b);

                //Assert
                Assert.That(act, Is.EqualTo(result));
            }
            [Test]
            public void Mnozenie_powinna_zwrocic_sume_a_i_b()
            {
                //aaa
                //Arrange
                double a = 10;
                double b = 5;
                double result = 50;

                //act
                double act = _kalkulator.mnozenie(a, b);

                //Assert
                Assert.That(act, Is.EqualTo(result));
            }
            [Test]
            public void Dzielenie_powinna_zwrocic_sume_a_i_b()
            {
                //aaa
                //Arrange
                double a = 10;
                double b = 5;
                double result = 2;

                //act
                double act = _kalkulator.dzielenie(a, b);

                //Assert
                Assert.That(act, Is.EqualTo(result));
            }
        
    }
}