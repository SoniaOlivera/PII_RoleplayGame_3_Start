namespace RoleplayGame
{
    public interface IMagicCharacter: IHeros
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }
}
