using System.Collections.Generic;
namespace RoleplayGame
{
    public class Heros : Character
    {
        public Heros(string name) : base(name)
        {
            this.Pv = Pv;
        }
        public int Pv { get; set; }
        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        
    }
}
