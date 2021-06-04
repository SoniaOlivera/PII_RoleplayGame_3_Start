using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: IHeros
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Dwarf(string name)
        {
            this.Name = name;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }

        
    }
}