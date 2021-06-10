using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class BowTests
    {
        private Bow Belthronding;
        [SetUp]
        public void Setup()
        {
         this.Belthronding = new Bow();
        }

        [Test]
        public void TestGetAttack()
        {
          Assert.AreEqual(15, Belthronding.AttackValue);  
        }
    }
}