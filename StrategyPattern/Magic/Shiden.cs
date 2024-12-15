namespace goodWayCoding.StrategyPattern.Magic;

public class Shiden : IMagic
{
    private Member member;

    public Shiden(Member member)
    {
        this.member = member;
    }

    public int attackPower()
    {
        return 50 + (int)(member.agility * 1.5);
    }

    public int costMagicPoint()
    {
        return 5 + (int)(member.level * 0.2);
    }

    public int costTechnicalPoint()
    {
        return 5;
    }

    public string name()
    {
        return "紫電";
    }
}
