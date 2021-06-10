using System.Collections.Generic;
namespace RoleplayGame
{
    public class Troll : BadGuys
    {
        public Troll(string name) : base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
    }
}