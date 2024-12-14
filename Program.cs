using System.Globalization;
using goodWayCoding.ValueObject;

var money1 = new Money(10, new RegionInfo("en-US"));
var money2 = new Money(20, new RegionInfo("en-US"));
var total = money1.add(money2);

Console.WriteLine(total.amount);
