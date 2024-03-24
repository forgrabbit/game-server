namespace GameServer.GameLogic;

public class Grenade : IGrenade
{
    //定点爆炸的坐标
    public Position position { get; set; }
    //爆炸的tick
    public int explodeTick { get; set; }
    //是否已经爆炸，初始为false
    public bool hasExploded { get; set; } = false;


    //构造函数：初始化手雷的爆炸位置、扔出的tick
    public Grenade(Position position, int throwTick)
    {
        this.position = position;
        explodeTick = throwTick+Constant.GRENADE_EXPLODE_TICK;
    }

    //判断手雷是否爆炸，如果tick>=ExplodeTick，爆炸，设HasExploded为True
    //  进行范围伤害计算并作用到player上，并return true;
    //否则return false
    public bool Explode(int tick, IPlayer[] players)
    {
        if (tick >= explodeTick)
        {
            hasExploded = true;
            foreach (Player player in players)
            {
                player.TakeDamage(ComputeGrenadeDamage(position, player.PlayerPosition));
            }
            return true;
        }
        return false;
    }

    private int ComputeGrenadeDamage(Position explodePosition, Position playerPosition){
        //TODO: implement
        throw new NotImplementedException();
    }
}
