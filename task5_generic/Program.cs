using task5_generic;

IStorage<string> stringStorage = new ListStorage<string>();
stringStorage.Add("string1");
stringStorage.Add("string2");
stringStorage.Add("string3");

var firstItem = stringStorage.Get(0);
if (firstItem != null)
    Console.WriteLine($"Element equals: {firstItem}");
else
    Console.WriteLine("Element not found.");