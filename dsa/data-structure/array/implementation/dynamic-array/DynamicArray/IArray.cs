namespace DynamicArray;

public interface IArray<T>
{
    public void Add(T value);
    public void Add(int index, T value);
    public void Clear();
    public bool Contains(T value);
    public bool IsEmpty();
    public T Get(int index);
    public int IndexOf(T value);
    public void Remove(T value);
    public void RemoveAt(int index);
    public void Set(int index, T value);
    public int Size();
    public string ToString();
}
