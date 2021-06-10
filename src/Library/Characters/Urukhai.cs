using System;

namespace RoleplayGame
{
    public class Urukhai : BadGuys
    {
        public Urukhai(string name) : base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}