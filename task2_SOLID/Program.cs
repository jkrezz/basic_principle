using task2_SOLID;

double price = 100;

Console.WriteLine($"Стандартная цена {price}\n");

Discount percentageDiscount = new PercentageDiscount(20);
Console.WriteLine($"Цена со скидкой 20%: {percentageDiscount.Calculate(price)}\n");

Discount fixedAmountDiscount = new FixedAmountDiscount(15); // Скидка 15
Console.WriteLine($"Цена со скидкой фиксированной суммы: {fixedAmountDiscount.Calculate(price)}");