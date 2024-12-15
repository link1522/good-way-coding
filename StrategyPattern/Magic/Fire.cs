using goodWayCoding.StrategyPattern.VO;

namespace goodWayCoding.StrategyPattern.Magic;

public class Fire : IMagic
{
    private readonly Member member;

    public Fire(Member member)
    {
        this.member = member;
    }

    public AttackPower attackPower()
    {
        var value = 20 + (int)(member.level * 0.5);
        return new AttackPower(value);
    }

    public MagicPoint costMagicPoint()
    {
        return new MagicPoint(2);
    }

    public TechnicalPoint costTechnicalPoint()
    {
        return new TechnicalPoint(0);
    }

    public string name()
    {
        return "烈焰";
    }
}
