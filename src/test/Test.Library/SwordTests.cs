using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class SwordTest
    {
        private Sword Anduir;
        [SetUp]
        public void Setup()
        {
         this.Anduir = new Sword();
        }

        [Test]
        public void TestGetAttack()
        {
          Assert.AreEqual(20, Anduir.AttackValue);  
        }
    }
}