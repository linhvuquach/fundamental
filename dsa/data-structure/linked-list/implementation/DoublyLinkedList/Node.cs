namespace DoublyLinkedList;

public class Node<T>
{
    private T data;
    private Node<T> previous, next;

    public Node(T data, Node<T> previous, Node<T> next)
    {
        this.Data = data;
        this.Previous = previous;
        this.next = next;
    }

    public T Data { get => data; set => data = value; }
    internal Node<T> Previous { get => previous; set => previous = value; }
    internal Node<T> Next { get => next; set => next = value; }
}
