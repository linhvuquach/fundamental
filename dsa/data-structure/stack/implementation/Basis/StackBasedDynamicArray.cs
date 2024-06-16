using System.Collections;
using DynamicArray;
using StackBasedLinkedList;

namespace StackBasedDynamicArray;

public class StackBasedDynamicArray<T> : IStack<T>
{
    private DynamicArray<T> list = new DynamicArray<T>();

    public bool IsEmpty()
    {
        return list.Size() == 0;
    }

    public T Peek()
    {
        return list.Get(list.Size() - 1);
    }

    public T Pop()
    {
        return list.RemoveAt(list.Size() - 1);
    }

    public void Push(T element)
    {
        list.Add(element);
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
