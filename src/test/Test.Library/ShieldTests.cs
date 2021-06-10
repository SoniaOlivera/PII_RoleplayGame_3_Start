using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ShieldTests
    {
        private Shield RoundShield;
        [SetUp]
        public void Setup()
        {
         this.RoundShield = new Shield();
        }

        [Test]
        public void TestGetDefense()
        {
          Assert.AreEqual(14, RoundShield.DefenseValue);  
        }
    }
}