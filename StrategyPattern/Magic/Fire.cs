namespace goodWayCoding.StrategyPattern.Magic;

public class Fire : IMagic
{
    private readonly Member member;

    public Fire(Member member)
    {
        this.member = member;
    }

    public int attackPower()
    {
        return 20 + (int)(member.level * 0.5);
    }

    public int costMagicPoint()
    {
        return 2;
    }

    public int costTechnicalPoint()
    {
        return 0;
    }

    public string name()
    {
        return "烈焰";
    }
}
