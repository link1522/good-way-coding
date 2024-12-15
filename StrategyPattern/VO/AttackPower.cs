namespace goodWayCoding.StrategyPattern.VO;

public class AttackPower
{
    static readonly int MIN = 0;
    public readonly int value;

    public AttackPower(int value)
    {
        if (value < MIN)
        {
            throw new ArgumentOutOfRangeException();
        }

        this.value = value;
    }

    public override string ToString()
    {
        return value.ToString();
    }
}
