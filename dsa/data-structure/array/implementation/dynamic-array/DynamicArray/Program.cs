using DynamicArray;

DynamicArray<String> dynamicArray =
[
    "L",
    "i",
    "n",
    "h",
    "V",
    "u",
    "Q",
    "u",
    "a",
    "c",
    "h",
];

dynamicArray.Add(dynamicArray.Size(), "2024");

Console.WriteLine(dynamicArray.ToString());
Console.WriteLine($"Array size is: {dynamicArray.Size()}");
Console.WriteLine($"Item at 3: {dynamicArray.Get(3)}");
Console.WriteLine($"Index of Q item: {dynamicArray.IndexOf("Q")}");

dynamicArray.RemoveAt(7);

foreach (String? item in dynamicArray)
{
    Console.WriteLine(item);
}

dynamicArray.Clear();
Console.WriteLine(dynamicArray.ToString());
Console.WriteLine("Get Element at 3:" + dynamicArray.Get(3));
Console.WriteLine($"Array size is: {dynamicArray.Size()}");
