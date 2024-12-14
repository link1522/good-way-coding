using System.Globalization;

namespace goodWayCoding.ValueObject;

public class Money
{
    /*
     * 將屬性修飾為不可變，避免因為修改程式碼流程出現意料之外的副作用
     */
    public readonly int amount;
    public readonly RegionInfo currency;

    /*
     * 一定要有建構子，建構子中需要有防衛子句 (guard clause)
     */
    public Money(int amount, RegionInfo currency)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("請指定 0 以上的金額");
        }

        if (currency is null)
        {
            throw new ArgumentNullException("請指定貨幣");
        }

        this.amount = amount;
        this.currency = currency;
    }

    /*
    * - 要修改內容時，直接建立新物件，同時也可以透過建構子避免出現無效值
    * - 用值類別來防止傳入錯誤的值，例如要操作 Money 的增加，就要用 Money 的值類別 add(Money money)
    */
    public Money add(Money other)
    {
        if (!currency.Equals(other.currency))
        {
            throw new ArgumentException("兩個金額的貨幣不同");
        }

        int added = amount + other.amount;
        return new Money(added, currency);
    }
}
