int[] numbers = { 2, 1, 3, 1, -2 };
Console.WriteLine(FindMin(numbers));

static T FindMin<T>(T[] array) where T : IComparable<T>
{
    T min = array[0];
    foreach (T t in array)
    {
        if(t.CompareTo(min) < 0)
            min = t;
    }
    return min;
}