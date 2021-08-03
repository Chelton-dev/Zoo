using System;
using Xunit;
using Staffs;

namespace StaffTests
{
    public class StaffTest
    {

        Staff zooKeeper;

        public StaffTest() {
            this.zooKeeper = new Staff("Bob", "ZooKeeeper", 1960);
        }

        [Fact]
        public void GetDetailsTest() {
            Assert.Equal("Bob is a ZooKeeper", zooKeeper.GetDetails());
        }

        [Fact]
        public void GetAgeTest() {
            Assert.Equal(61, zooKeeper.GetAge());
        }

    }
}
