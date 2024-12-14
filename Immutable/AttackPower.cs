namespace goodWayCoding.Immutable;

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

    public AttackPower reinForce(AttackPower increment)
    {
        return new AttackPower(value + increment.value);
    }

    public AttackPower disable()
    {
        return new AttackPower(MIN);
    }
}
