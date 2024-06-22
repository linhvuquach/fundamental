namespace QueueBasis;

public interface IQueue<T> : IEnumerable<T>
{
    void Enqueue(T element);
    T Dequeue();
    T Peek();
    bool IsEmpty();
    int Size();
}
