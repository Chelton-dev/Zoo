using System;

namespace Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public string MakeSound() {
            return $"{this.Name} makes a {this.Sound} sound";
        }
    }
}
