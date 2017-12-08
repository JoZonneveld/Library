public interface ILinkedList<T>
{
    bool IsEmpty();
    T Value {get; set;}
    ILinkedList<T> Tail {get; set;}
}

public class Node<T> : ILinkedList<T>
{
    T ILinkedList<T>.Value { get => this.value; set => this.value = value; }
    ILinkedList<T> ILinkedList<T>.Tail { get => this.tail; set => this.tail = value; }

    public T value;
    public ILinkedList<T> tail;
    
    public Node(T value, ILinkedList<T> tail)
    {
        this.value = value;
        this.tail = tail;
    }

    bool ILinkedList<T>.IsEmpty()
    {
        return false;
    }
}

public class Empty<T> : ILinkedList<T>
{
    T ILinkedList<T>.Value { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    ILinkedList<T> ILinkedList<T>.Tail { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    bool ILinkedList<T>.IsEmpty()
    {
        return true;
    }
}
