namespace StackBasedLinkedList;

public interface IStack<T> : IEnumerable<T>
{
    void Push(T element);
    T Pop();
    T Peek();
    int Size();
    bool IsEmpty();
}
