using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTests
    {
        private Dwarf Gimli;
        private Helmet helmet;
        private Axe axe;

        [SetUp]
        public void Setup()
        {
            this.Gimli = new Dwarf("Gimli");
            this.helmet = new Helmet();
            this.axe = new Axe();
        }

        [Test]
          public void TestAgregarItem()
        {
            Gimli.AddItem(helmet);
            Assert.IsNotEmpty(Gimli.Items);
        }
        [Test]
          public void TestQuitarItem()
        {
            Gimli.RemoveItem(helmet);
            bool hasHelmet = false;
            foreach (IItem item in Gimli.Items)
            {
                if (item == helmet)
                {
                    hasHelmet = true;
                }
            }
            Assert.IsFalse(hasHelmet);
        }
        [Test]
         public void TestAttackValue()
        {
            Assert.AreEqual(25, Gimli.AttackValue);
        }
        [Test]
        public void TestAttackValueManyItems()
        {
            Gimli.AddItem(axe);
            Gimli.AddItem(axe);
            Assert.AreEqual(75, Gimli.AttackValue);
        }
        [Test]
         public void TestDefenseValue()
        {
            Assert.AreEqual(18, Gimli.DefenseValue);
        }
         [Test]
         public void TestHealth()
        {
            Assert.AreEqual(100, Gimli.Health);
        }
        [Test]
         public void TestReceiveDamage()
        {
            Gimli.ReceiveAttack(20);
            Assert.AreEqual(80, Gimli.Health);
        }
        [Test]
         public void TestReceiveDamagemuygrande()
        {
            Gimli.ReceiveAttack(200000);
            Assert.AreEqual(0, Gimli.Health);
        }
        [Test]
         public void TestCure()
        {
            Gimli.ReceiveAttack(200000);
            Gimli.Cure();
            Assert.AreEqual(100, Gimli.Health);
        }
    }
}
