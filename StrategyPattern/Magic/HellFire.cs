using goodWayCoding.StrategyPattern.VO;

namespace goodWayCoding.StrategyPattern.Magic;

public class HellFire : IMagic
{
    private Member member;

    public HellFire(Member member)
    {
        this.member = member;
    }

    public AttackPower attackPower()
    {
        var value = 200 + (int)(member.magicAttack * 0.5 + member.vitality * 2);
        return new AttackPower(value);
    }

    public MagicPoint costMagicPoint()
    {
        return new MagicPoint(16);
    }

    public TechnicalPoint costTechnicalPoint()
    {
        var value = 20 + (int)(member.level * 0.4);
        return new TechnicalPoint(value);
    }

    public string name()
    {
        return "地獄之業火";
    }
}
