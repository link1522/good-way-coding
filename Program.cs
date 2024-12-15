using goodWayCoding.StrategyPattern;
using goodWayCoding.StrategyPattern.Magic;
using goodWayCoding.StrategyPattern.VO;

var magics = new Dictionary<MagicType, IMagic>();

var member = new Member
{
    level = 10,
    vitality = 12,
    magicAttack = 15,
    agility = 8
};

var fire = new Fire(member);
var shiden = new Shiden(member);
var hellFire = new HellFire(member);

magics.Add(MagicType.fire, fire);
magics.Add(MagicType.shiden, shiden);
magics.Add(MagicType.hellFire, hellFire);

var magicManager = new MagicManager(magics);
magicManager.magicAttack(MagicType.hellFire);