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
    }
}
