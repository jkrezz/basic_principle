int a = 5;
int b = 10;

Console.WriteLine($"a = {a}, b = {b}");
(a, b) = Swap(a, b);
Console.WriteLine($"after swap: a = {a}, b = {b}");

static (T, T) Swap<T>(T first, T second)
{
    return (second, first);
}