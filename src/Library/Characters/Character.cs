using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Character
    {
        protected int health = 100;

        public List<IItem> Items { get; protected set; }
        public Character(string name)
        {
            this.Name = name;
            this.Items = new List<IItem>();
        }

        public string Name { get; protected set; }

        public virtual int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.Items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public virtual int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.Items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            this.Health = this.Health - power;
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.Items.Remove(item);
        }
    }
}