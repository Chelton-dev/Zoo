using System;

namespace Staffs
{
    public class Staff
    {


        public string Name { get; set; }
        public string Job { get; set; }
        public int YearOfBirth { get; set; }

        public Staff(string name, string job, int yearOfBirth) {
            this.Name = name;
            this.Job = job;
            this.YearOfBirth = yearOfBirth;
        }

        public string GetDetails() {
            return $"{this.Name} is a {this.Name}";
        }

        public int GetAge() {
            return 2021 - this.YearOfBirth;
        }
    }
}
