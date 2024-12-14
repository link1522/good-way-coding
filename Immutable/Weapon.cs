namespace goodWayCoding.Immutable;

public class Weapon
{
    public readonly AttackPower attackPower;

    public Weapon(AttackPower attackPower)
    {
        this.attackPower = attackPower;
    }

    public Weapon reinForce(AttackPower increment)
    {
        AttackPower reinForce = attackPower.reinForce(increment);
        return new Weapon(reinForce);
    }
}
