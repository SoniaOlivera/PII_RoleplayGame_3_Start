using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Encounter
    {
        protected List<Heros> herolist = new List<Heros>();
        protected List<BadGuys> badguylist = new List<BadGuys>();

        public abstract void DoEncounter();
    }
}