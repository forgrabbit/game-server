namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public int Health;
    public double Speed;
    public Armor? PlayerArmor = null;
    public Position PlayerPosition  => throw new NotImplementedException();
    public IWeapon PlayerWeapon = new Fist();
    public IBackPack PlayerBackPack => throw new NotImplementedException();

    public void TakeDamage(int damage)
    {
        //TODO: implement
        throw new NotImplementedException();
    }
}
