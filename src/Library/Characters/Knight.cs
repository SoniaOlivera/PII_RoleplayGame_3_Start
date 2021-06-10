using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Heros
    {


        public Knight(string name) : base(name)
        {
                       
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }

        
    }
}