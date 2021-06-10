using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Battle : Encounter
    {
        public override void DoEncounter()
        {
            while (herolist.Count >= 1 && badguylist.Count >= 1)
            {
                foreach (BadGuys enemy in badguylist)
                {
                    if (badguylist[enemy]  <= herolist.Count )
                    {
                        herolist[badguylist[enemy]].ReceiveAttack(enemy.AttackValue);
                        if (herolist[badguylist[enemy]].Health <= 0)
                        {
                            herolist.Remove(badguylist[enemy]);
                        }
                    }
                    if (badguylist.Count > herolist.Count )
                    {
                        int nextindex = badguylist.Count;
                        while (nextindex > herolist.Count)
                        {
                            nextindex = nextindex - herolist.Count;
                        }
                        herolist[nextindex].ReceiveAttack(enemy.AttackValue);
                        if (herolist[nextindex].Health <= 0)
                        {
                            herolist.Remove(herolist[nextindex]);
                        }
                    }
                }
                foreach (Hero heroe in herolist)
                {
                    foreach (BadGuys enemy in badguylist)
                    {
                        enemy.ReceiveAttack(heroe.AttackValue);
                        if (enemy.Health <= 0)
                        {
                            heroe.AddVP(enemy.VP);
                            badguylist.Remove(enemy);
                        }
                    }
                    if (heroe.VP > 4)
                    {
                        heroe.AddVP(-5);
                        heroe.Cure();
                    }
                }
            }
        }
    }
}