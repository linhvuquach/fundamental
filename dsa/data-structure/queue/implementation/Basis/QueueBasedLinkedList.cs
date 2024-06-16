using System.Collections;
using DoublyLinkedList;

namespace QueueBasis;

public class QueueBasedLinkedList<T> : IQueue<T>
{
    private DoublyLinkedList<T> list = new DoublyLinkedList<T>();

    public T Dequeue()
    {
        if (IsEmpty()) throw new InvalidOperationException("Queue is empty");

        T value = list.PeekLast();
        list.RemoveLast();

        return value;
    }

    public void Enqueue(T element)
    {
        list.AddFirst(element);
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }

    public T Peek()
    {
        return list.PeekLast();
    }

    public int Size()
    {
        return list.Size();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
