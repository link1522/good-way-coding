namespace goodWayCoding.StrategyPattern.Magic;

/*
 * 當軟體系統必須提供一組選項時，應該只由唯一一個模組掌控所有的選項
 */

public interface IMagic
{
    string name();
    int costMagicPoint();
    int attackPower();
    int costTechnicalPoint();
}
