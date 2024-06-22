
using QueueBasis;

// QueueBasedLinkedList<string> queueBasedLinkedList = new QueueBasedLinkedList<string>();
// queueBasedLinkedList.Enqueue("Linh");
// queueBasedLinkedList.Enqueue("Vu");
// queueBasedLinkedList.Enqueue("Quach");

// Console.WriteLine($"Size: {queueBasedLinkedList.Size()}");
// Console.WriteLine($"Peek: {queueBasedLinkedList.Peek()}");

// queueBasedLinkedList.Dequeue();

// foreach (string element in queueBasedLinkedList)
// {
//     Console.WriteLine(element);
// }

int numberOfOperations = 100000;
CircularArrayQueue<int> circularArrayQueue = new CircularArrayQueue<int>(numberOfOperations);

for (int i = 0; i < numberOfOperations; i++)
{
    circularArrayQueue.Enqueue(i);
}

Console.WriteLine($"Size: {circularArrayQueue.Size()}");
Console.WriteLine($"Peek: {circularArrayQueue.Peek()}");

for (int i = 0; i < numberOfOperations; i++)
{
    circularArrayQueue.Dequeue();
}

Console.WriteLine($"Size: {circularArrayQueue.Size()}");

foreach (int element in circularArrayQueue)
{
    Console.WriteLine(element);
}
