using System;

namespace Staff
{
    public class Staff
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int YearOfBirth { get; set; }

        public string GetDetails() {
            return $"{this.Name} is a {this.Name}";
        }

        public int GetAge() {
            return 2021 - this.YearOfBirth;
        }
    }
}
