using DoublyLinkedList;

DoublyLinkedList<String> linkedList = new DoublyLinkedList<String>();

linkedList.Add("Linh");
linkedList.Add("Vu");
linkedList.Add("Quach");

linkedList.AddFirst("AAVN");
linkedList.AddLast("2024");

Console.WriteLine(linkedList.ToString());

Console.WriteLine($"Contain of AAVN: {linkedList.Contains("AAVN")}");
Console.WriteLine($"Index of Linh: {linkedList.IndexOf("Linh")}");

linkedList.RemoveAt(2);
linkedList.Remove(elementObject: "Linh");

Console.WriteLine(linkedList.ToString());

linkedList.RemoveFirst();
linkedList.RemoveLast();

// Test enumberator
linkedList.AddLast("Vu");
linkedList.AddLast("Linh");

foreach (var item in linkedList)
{
    Console.Write(item);
}