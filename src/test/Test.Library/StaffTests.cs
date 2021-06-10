using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class StaffTests
    {
        private Staff GandalfStaff;
        [SetUp]
        public void Setup()
        {
         this.GandalfStaff = new Staff();
        }

        [Test]
        public void TestGetAttack()
        {
          Assert.AreEqual(100, GandalfStaff.AttackValue);  
        }
        
        [Test]
        public void TestGetDefense()
        {
            Assert.AreEqual(100, GandalfStaff.DefenseValue);
        }
    }
}