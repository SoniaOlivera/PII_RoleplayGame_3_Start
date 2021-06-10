using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class AxeTest
    {
        private Axe DurinAxe;
        [SetUp]
        public void Setup()
        {
         this.DurinAxe = new Axe();
        }

        [Test]
        public void TestGetAttack()
        {
          Assert.AreEqual(25, DurinAxe.AttackValue);  
        }
    }
}