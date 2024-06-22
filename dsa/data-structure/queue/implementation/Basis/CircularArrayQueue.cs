using System.Collections;

namespace QueueBasis;

public class CircularArrayQueue<T> : IQueue<T>
{
    private T[] array;
    private int front, rear, size;

    public CircularArrayQueue(int maxSize)
    {
        front = rear = 0;
        size = maxSize + 1;
        Array.Resize(ref array, size);
    }

    public T Dequeue()
    {
        if (IsEmpty()) throw new ArgumentNullException("Queue is empty");

        T element = array[front];
        array[front] = default;

        if (++front == size) front = 0;

        return element;
    }

    public void Enqueue(T element)
    {
        array[rear] = element;

        if (++rear == size) rear = 0;
        if (rear == front) throw new ArgumentException("Queue is full");
    }

    public bool IsEmpty()
    {
        return front == rear;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new ArgumentNullException("Queue is empty");

        return array[front];
    }

    public int Size()
    {
        if (front > rear) return size + rear - front;
        return rear - front;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Size(); i++)
        {
            yield return array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
