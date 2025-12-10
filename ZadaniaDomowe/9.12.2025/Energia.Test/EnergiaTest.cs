using NUnit.Framework;
using Energia;

namespace Energia.Test
{
    public class EnergiaTest
    {
        private Energia _energia;

        [SetUp]
        public void SetUp()
        {
            _energia = new Energia();
        }

        [Test]
        public void Ep_powinna_obliczyc_energie_potencjalna()
        {
            // Arrange
            double m = 10;
            double g = 9.81;
            double h = 2;
            double result = m * g * h;

            // Act
            double act = _energia.Ep(m, g, h);

            // Assert
            Assert.That(act, Is.EqualTo(result));
        }

        [Test]
        public void Ek_powinna_obliczyc_energie_kinetyczna()
        {
            // Arrange
            double m = 10;
            double v = 3;
            double result = 0.5 * m * v * v;

            // Act
            double act = _energia.Ek(m, v);

            // Assert
            Assert.That(act, Is.EqualTo(result));
        }

        [Test]
        public void Em_powinna_obliczyc_energie_mechaniczna()
        {
            // Arrange
            double ep = 50;
            double ek = 20;
            double result = ep + ek;

            // Act
            double act = _energia.Em(ep, ek);

            // Assert
            Assert.That(act, Is.EqualTo(result));
        }
    }
}
