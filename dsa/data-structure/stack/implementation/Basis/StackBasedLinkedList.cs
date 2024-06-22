using System.Collections;
using DoublyLinkedList;

namespace StackBasedLinkedList;

public class StackBasedLinkedList<T> : IStack<T>
{
    private DoublyLinkedList<T> list = new DoublyLinkedList<T>();

    public bool IsEmpty()
    {
        return list.Size() == 0;
    }

    public T Peek()
    {
        return list.PeekFirst();
    }

    public T Pop()
    {
        return list.RemoveFirst();
    }

    public void Push(T element)
    {
        list.AddFirst(element);
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
