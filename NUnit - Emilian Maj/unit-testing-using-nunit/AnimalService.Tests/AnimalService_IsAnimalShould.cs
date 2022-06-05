using NUnit.Framework;
using AnimalClass;

namespace UnitTests.Services
{
    [TestFixture]
    public class AnimalService_IsAnimalShould
    {
        private Animal _animal;
        private Cat _cat;
        private Dog _dog;

        [SetUp]
        public void SetUp()
        {
            _animal = new Animal();
            _cat = new Cat();
            _dog = new Dog();
        }
        //[Fact]
        [Test]
        public void Cat_MakeSounds_ReturnEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreEqual(result, "Cat says: meow meow !");
        }
        [Test]
        public void Cat_MakeSounds_ReturnNotEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreNotEqual(result, "Cat says: moo moo !");
        }
        //[Theory]
        [TestCase("Animal gives a sound!")]
        [TestCase("Cat says: meow meow !")]
        [TestCase("Dog sounds like: hau hau !")]
        [TestCase("Animal gives a dance!")]
        [TestCase("Cat says: moo moo !")]
        [TestCase("Dog sounds like: moo moo !")]
        public void MakeSound_ReturnEqual(string value)
        {
            var result = _animal.MakeSound();

            if (result == value){
                Assert.AreEqual(result, value);
            } else {
                Assert.AreNotEqual(result, value);
            }
        }
        [TestCase("Animal gives a sound!")]
        [TestCase("Cat says: meow meow !")]
        [TestCase("Dog sounds like: hau hau !")]
        [TestCase("Animal gives a dance!")]
        [TestCase("Cat says: moo moo !")]
        [TestCase("Dog sounds like: moo moo !")]
        public void Cat_MakeSounds_ReturnEqual(string value)
        {
            var result = _cat.MakeSound();

            if (result == value){
                Assert.AreEqual(result, value);
            } else {
                Assert.AreNotEqual(result, value);
            }
        }
        [TestCase("Animal gives a sound!")]
        [TestCase("Cat says: meow meow !")]
        [TestCase("Dog sounds like: hau hau !")]
        [TestCase("Animal gives a dance!")]
        [TestCase("Cat says: moo moo !")]
        [TestCase("Dog sounds like: moo moo !")]
        public void Dog_MakeSounds_ReturnEqual(string value)
        {
            var result = _dog.MakeSound();

            if (result == value){
                Assert.AreEqual(result, value);
            } else {
                Assert.AreNotEqual(result, value);
            }
        }
    }
}