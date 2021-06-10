using NUnit.Framework;
using RoleplayGame;
using System;

namespace Test.Library
{
    public class ArmorTest
    {
        private Armor Chestplate;
        [SetUp]
        public void Setup()
        {
         this.Chestplate = new Armor();
        
        }

        [Test]
        public void TestGetDefense()
        {
            Assert.AreEqual(25, Chestplate.DefenseValue);  
        }
    }
}