using goodWayCoding.Immutable;

var weaponA = new Weapon(new AttackPower(20));
var weaponB = new Weapon(new AttackPower(30));

var reinForcedWeaponA = weaponA.reinForce(new AttackPower(30));
