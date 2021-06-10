using System;

namespace RoleplayGame
{
    public class Goblin : BadGuys
    {
        public Goblin(string name) : base(name, 1)
        {
            this.AddItem(new Sword());
        }
    }
}