using System.Collections;
using System.Text;

namespace DynamicArray;

public class DynamicArray<T> : IEnumerable<T>, IArray<T>
{
    private T[] arr;
    private int size, capicity;

    public DynamicArray()
    {
        capicity = 10;
        Array.Resize(ref arr, capicity);
    }

    public DynamicArray(int capicity)
    {
        if (capicity < 0) throw new ArgumentException("Capicity can't be negative");
        this.capicity = capicity;
        Array.Resize(ref arr, capicity);
    }

    public void Add(T value)
    {
        if (size >= capicity - 1)
        {
            capicity *= 2;
            Array.Resize(ref arr, capicity);
        }
        arr[size++] = value;
    }

    public void Add(int index, T value)
    {
        if (index < 0 || index > size) throw new IndexOutOfRangeException("Index out of range");
        if (size >= capicity - 1)
        {
            capicity *= 2;
            Array.Resize(ref arr, capicity);
        }

        for (int i = size; i > index; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[index] = value;
        size++;
    }

    public void Clear()
    {
        for (int i = 0; i < size; i++)
        {
            arr[i] = default(T);
        }
        size = 0;
    }

    public bool Contains(T value)
    {
        for (int i = 0; i < size; i++)
        {
            if (arr[i].Equals(value)) return true;
        }
        return false;
    }

    public T Get(int index)
    {
        return arr[index];
    }

    public int IndexOf(T value)
    {
        for (int i = 0; i < size; i++)
        {
            if (arr[i].Equals(value)) return i;
        }

        return -1;
    }

    public void Remove(T value)
    {
        // for (int i = 0; i < size; i++)
        // {
        //     if (arr[i].Equals(value))
        //     {
        //         for (int j = i; j < size - 1; j++)
        //         {
        //             arr[j] = arr[j + 1];
        //         }
        //         size--;
        //         return;
        //     }
        // }

        int removeIndex = IndexOf(value);
        RemoveAt(removeIndex);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= size) throw new IndexOutOfRangeException("Index out of range");
        for (int i = index; i < size - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        size--;
    }

    public void Set(int index, T value)
    {
        arr[index] = value;
    }

    public int Size()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < size; i++)
        {
            sb.Append(arr[i]);
            if (i < size - 1) sb.Append(", ");
        }
        sb.Append("]");

        return sb.ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < size; i++)
        {
            yield return arr[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
