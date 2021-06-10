using System.Collections.Generic;
namespace RoleplayGame
{
    public class BadGuys : Character
    {
        public BadGuys(string name) : base(name)
        {
            this.Pv = Pv;
        }

        public int Pv { get; set; }

        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        public int CheckHealth()
        {
            if ( this.Health <= 0 )
            {
                return this.Pv;
            }
            else
                return 0;
        }

        
    }
}