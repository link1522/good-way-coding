using goodWayCoding.StrategyPattern.Magic;

namespace goodWayCoding.StrategyPattern;

public class MagicManager
{
    private Dictionary<MagicType, IMagic> magics;

    public MagicManager(Dictionary<MagicType, IMagic> magics)
    {
        this.magics = magics;
    }

    public void magicAttack(MagicType magicType)
    {
        var usingMagic = magics[magicType];
        showMagicName(usingMagic);
        consumeMagicPoint(usingMagic);
        consumeTechnialPoint(usingMagic);
        magicDamage(usingMagic);
    }

    private void showMagicName(IMagic magic)
    {
        Console.WriteLine($"施放 {magic.name()}");
    }

    private void consumeMagicPoint(IMagic magic)
    {
        Console.WriteLine($"消耗魔力: {magic.costMagicPoint()}");
    }

    private void consumeTechnialPoint(IMagic magic)
    {
        Console.WriteLine($"消耗技能值: {magic.costTechnicalPoint()}");
    }

    private void magicDamage(IMagic magic)
    {
        Console.WriteLine($"造成傷害: {magic.attackPower()}");
    }
}
