using goodWayCoding.StrategyPattern.VO;
using Microsoft.VisualBasic;

namespace goodWayCoding.StrategyPattern.Magic;

public class Shiden : IMagic
{
    private Member member;

    public Shiden(Member member)
    {
        this.member = member;
    }

    public AttackPower attackPower()
    {
        var value = 50 + (int)(member.agility * 1.5);
        return new AttackPower(value);
    }

    public MagicPoint costMagicPoint()
    {
        var value = 5 + (int)(member.level * 0.2);
        return new MagicPoint(value);
    }

    public TechnicalPoint costTechnicalPoint()
    {
        return new TechnicalPoint(5);

    }

    public string name()
    {
        return "紫電";
    }
}
