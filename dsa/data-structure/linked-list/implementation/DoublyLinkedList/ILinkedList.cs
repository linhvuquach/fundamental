namespace DoublyLinkedList;

public interface ILinkedList<T> : IEnumerable<T>
{
    void Add(T element);
    void Add(T element, int index);
    void AddFirst(T element);
    void AddLast(T element);
    T Remove(Node<T> node);
    void RemoveAt(int index);
    T RemoveFirst();
    T RemoveLast();
    bool Remove(Object elementObject);
    T PeekFirst();
    T PeekLast();
    int IndexOf(Object elementObject);
    bool Contains(Object elementObject);
    int Size();
    bool IsEmpty();
    void Clear();
    string ToString();
}
