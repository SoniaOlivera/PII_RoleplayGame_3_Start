using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Encounter
    {
        protected List<Hero> herolist = new List<Hero>();
        protected List<BadGuys> badguylist = new List<BadGuys>();

        public abstract void DoEncounter();
    }
}