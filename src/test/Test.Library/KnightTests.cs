using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class KnightTests
    {
        private Knight Aragorn;
        private Armor armor;
        private Sword sword;

        [SetUp]
        public void Setup()
        {
            this.Aragorn = new Knight("Aragorn");
            this.armor = new Armor();
            this.sword = new Sword();
        }

        [Test]
          public void TestAgregarItem()
        {
            Aragorn.AddItem(armor);
            Assert.IsNotEmpty(Aragorn.Items);
        }
        [Test]
          public void TestQuitarItem()
        {
            Aragorn.RemoveItem(armor);
            bool hasArmor = false;
            foreach (IItem item in Aragorn.Items)
            {
                if (item == armor)
                {
                    hasArmor = true;
                }
            }
            Assert.IsFalse(hasArmor);
        }
        [Test]
         public void TestAttackValue()
        {
            Assert.AreEqual(20, Aragorn.AttackValue);
        }
        [Test]
        public void TestAttackValueTwoItems()
        {
            Aragorn.AddItem(sword);
            Assert.AreEqual(40, Aragorn.AttackValue);
        }
        [Test]
         public void TestDefenseValue()
        {
            Assert.AreEqual(39, Aragorn.DefenseValue);
        }
         [Test]
         public void TestHealth()
        {
            Assert.AreEqual(100, Aragorn.Health);
        }
        [Test]
         public void TestReceiveDamage()
        {
            Aragorn.ReceiveAttack(20);
            Assert.AreEqual(80, Aragorn.Health);
        }
        [Test]
         public void TestReceiveDamagemuygrande()
        {
            Aragorn.ReceiveAttack(200000);
            Assert.AreEqual(0, Aragorn.Health);
        }
        [Test]
         public void TestCure()
        {
            Aragorn.ReceiveAttack(200000);
            Aragorn.Cure();
            Assert.AreEqual(100, Aragorn.Health);
        }
    }
}
