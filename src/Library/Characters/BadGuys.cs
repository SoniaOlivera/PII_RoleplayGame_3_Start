using System.Collections.Generic;
namespace RoleplayGame
{
    public class BadGuys : Character
    {
        public int Vp { get; private set; }
        public BadGuys(string name, int vp) : base(name)
        {
            this.Vp = vp;
        }
        public override int AttackValue => base.AttackValue;
        public override int DefenseValue => base.DefenseValue;
    }
}