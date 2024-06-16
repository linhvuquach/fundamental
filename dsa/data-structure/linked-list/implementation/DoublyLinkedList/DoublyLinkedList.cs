using System.Collections;
using System.Text;

namespace DoublyLinkedList;

public class DoublyLinkedList<T> : ILinkedList<T>
{
    private Node<T> head, tail = null;
    private int size;


    public void Add(T element)
    {
        AddLast(element);
    }

    public void Add(T element, int index)
    {
        if (index < 0 || index >= size) throw new ArgumentException();

        if (index == 0) AddFirst(element);
        if (index == size) AddLast(element);

        int i;
        Node<T> currentNode;

        if (index < size / 2)
        {
            i = 0;
            currentNode = head;
            while (i != index)
            {
                i++;
                currentNode = currentNode.Next;
            }
        }
        else
        {
            i = size - 1;
            currentNode = tail;
            while (i != index)
            {
                i--;
                currentNode = currentNode.Previous;
            }
        }

        Node<T> newNode = new Node<T>(element, currentNode.Previous, currentNode);
        currentNode.Previous.Next = newNode;
        currentNode.Previous = newNode;

        size++;
    }

    public void AddFirst(T element)
    {
        if (IsEmpty())
        {
            head = tail = new Node<T>(element, null, null);
        }
        else
        {
            Node<T> newNode = new Node<T>(element, null, head);
            head.Previous = newNode;
            head = newNode;
        }

        size++;
    }

    public void AddLast(T element)
    {
        if (IsEmpty())
        {
            head = tail = new Node<T>(element, null, null);
        }
        else
        {
            Node<T> newNode = new Node<T>(element, tail, null);
            tail.Next = newNode;
            tail = newNode;
        }
        size++;
    }

    public void Clear()
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            Node<T> nextNode = currentNode.Next;

            currentNode.Next = null;
            currentNode.Previous = null;
            currentNode.Data = default;

            currentNode = nextNode;
        }

        head = tail = null;
        size = 0;
    }

    public bool Contains(object elementObject)
    {
        return IndexOf(elementObject) != -1;
    }

    public int IndexOf(object elementObject)
    {
        // i = 0, i++, size -1 and loop
        // check currentNode.data = elmObj
        // return i
        int i = 0;
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(elementObject)) return i;

            i++;
            currentNode = currentNode.Next;
        }

        return -1;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public T PeekFirst()
    {
        if (IsEmpty()) throw new ArgumentException("Linked list is empty");
        return head.Data;
    }

    public T PeekLast()
    {
        if (IsEmpty()) throw new ArgumentException("Linked list is empty");
        return tail.Data;
    }

    public T Remove(Node<T> node)
    {
        if (node.Previous == null) RemoveFirst();
        if (node.Next == null) RemoveLast();

        T data = node.Data;

        Node<T> previousNode = node.Previous;
        Node<T> nextNode = node.Next;
        previousNode.Next = nextNode;
        nextNode.Previous = previousNode;

        size--;

        node.Data = default;
        node.Previous = null;
        node.Next = null;

        return data;
    }

    public bool Remove(object elementObject)
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(elementObject))
            {
                Remove(currentNode);
                return true;
            }

            currentNode = currentNode.Next;
        }

        return false;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= size) throw new ArgumentException();

        int i;
        Node<T> currentNode;

        if (index < size / 2)
        {
            i = 0;
            currentNode = head;
            while (i != index)
            {
                i++;
                currentNode = currentNode.Next;
            }
        }
        else
        {
            i = size - 1;
            currentNode = tail;
            while (i != index)
            {
                i--;
                currentNode = currentNode.Previous;
            }
        }

        Remove(currentNode);
    }

    public T RemoveFirst()
    {
        if (IsEmpty()) throw new InvalidOperationException("List is empty");

        T data = head.Data;
        head = head.Next;
        size--;

        if (IsEmpty()) tail = null;
        else head.Previous = null;

        return data;
    }

    public T RemoveLast()
    {
        if (IsEmpty()) throw new InvalidOperationException("List is empty");

        T data = tail.Data;
        tail = tail.Previous;
        size--;

        if (IsEmpty()) head = null;
        else tail.Next = null;

        return data;
    }

    public int Size()
    {
        return size;
    }

    public override string ToString()
    {
        if (IsEmpty()) return "[]";

        else
        {
            StringBuilder sb = new StringBuilder(size).Append("[");
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                sb.Append(currentNode.Data);
                if (currentNode.Next != null) sb.Append(", ");

                currentNode = currentNode.Next;
            }

            sb.Append("]");
            return sb.ToString();
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            yield return currentNode.Data;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
