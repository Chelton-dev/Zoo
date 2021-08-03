using System;
using Xunit;
using Animals;

namespace ZooTests
{
    public class AnimalTests
    {
        Animal lion;
        Animal giraffe;

        public AnimalTests() {
            lion = new Animal();
            lion.Name = "Lion";
            lion.Sound = "ROAR";

            giraffe = new Animal();
            giraffe.Name = "Giraffe";
            giraffe.Sound = "Chew";
        }

        [Fact]
        public void MakeSoundTest()
        {
            Assert.Equal("Lion makes a ROAR sound", lion.MakeSound());
            Assert.Equal("Giraffe makes a Chew sound", giraffe.MakeSound());
        }

        [Theory]
        [InlineData("Lion makes a ROAR sound", "Lion", "ROAR")]
        [InlineData("Giraffe makes a Chew sound", "Giraffe", "Chew")]
        [InlineData("Cow makes a Moo sound", "Cow", "Moo")]
        public void MakeSoundTests(string actual, string name, string sound) {
            Animal testAnimal = new Animal();
            testAnimal.Name = name;
            testAnimal.Sound = sound;

            Assert.Equal(actual, testAnimal.MakeSound());
        }
    }
}
