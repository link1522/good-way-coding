namespace goodWayCoding.StrategyPattern.Magic;

public class HellFire : IMagic
{
    private Member member;

    public HellFire(Member member)
    {
        this.member = member;
    }

    public int attackPower()
    {
        return 200 + (int)(member.magicAttack * 0.5 + member.vitality * 2);
    }

    public int costMagicPoint()
    {
        return 16;
    }

    public int costTechnicalPoint()
    {
        return 20 + (int)(member.level * 0.4);
    }

    public string name()
    {
        return "地獄之業火";
    }
}
