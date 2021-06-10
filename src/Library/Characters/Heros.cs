using System.Collections.Generic;
namespace RoleplayGame
{
    public class Heros : Character
    {
        public int Vp { get; private set; }
        public Heros(string name) : base(name)
        {
            this.Vp = 0;
        }
        
        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        public void AddVP(int vp)
        {
            this.Vp = this.Vp + vp;
        }

        
    }
}
