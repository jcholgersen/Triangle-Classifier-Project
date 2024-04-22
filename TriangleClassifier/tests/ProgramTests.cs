namespace TriangleClassifier.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        // Invalid input 
        
        [Test]
        public void ParseDouble_InvalidInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Program.ParseDouble("not_a_double"));
            
            Assert.Throws<ArgumentException>(() => Program.ParseDouble(""));
           
            Assert.Throws<ArgumentException>(() => Program.ParseDouble(null));
        }

        // Valid input

        [Test]
        public void ParseDouble_ValidInputIntegerAsString_ReturnsDoubleValue()
        {
            double expected = 1;

            var actual = Program.ParseDouble("1");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ParseDouble_ValidInputDecimalAsString_ReturnsDoubleValue()
        {
            double expected = 1.2;

            var actual = Program.ParseDouble("1.2");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ParseDouble_ValidInputWithCommaAsString_ReturnsDoubleValue()
        {
            double expected = 1200;

            var actual = Program.ParseDouble("1,200");

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
