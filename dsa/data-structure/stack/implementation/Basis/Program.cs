
using StackBasedDynamicArray;
using StackBasedLinkedList;

// StackBasedLinkedList<string> stackBasedLinkedList = new StackBasedLinkedList<string>();
// stackBasedLinkedList.Push("Linh");
// stackBasedLinkedList.Push("Vu");
// stackBasedLinkedList.Push("Quach");

// Console.WriteLine($"Size: {stackBasedLinkedList.Size()}");
// Console.WriteLine($"Peek: {stackBasedLinkedList.Peek()}");

// stackBasedLinkedList.Pop();

// foreach (string element in stackBasedLinkedList)
// {
//     Console.WriteLine(element);
// }

StackBasedDynamicArray<string> stackBasedDynamicArray = new StackBasedDynamicArray<string>();
stackBasedDynamicArray.Push("Linh");
stackBasedDynamicArray.Push("Vu");
stackBasedDynamicArray.Push("Quach");

Console.WriteLine($"Size: {stackBasedDynamicArray.Size()}");
Console.WriteLine($"Peek: {stackBasedDynamicArray.Peek()}");

stackBasedDynamicArray.Pop();
Console.WriteLine($"Size: {stackBasedDynamicArray.Size()}");

foreach (string element in stackBasedDynamicArray)
{
    Console.WriteLine(element);
}
