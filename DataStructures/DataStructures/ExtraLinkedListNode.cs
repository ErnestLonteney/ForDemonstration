namespace DataStructures;

public class ExtraLinkedListNode<T> 
{
    internal ExtraLinkedListNode<T>? next;
    internal ExtraLinkedListNode<T>? previous;

    public ExtraLinkedListNode(T value)
    {
        Value = value;
    }

    public T? Value { get; set; }

    public ExtraLinkedListNode<T>? Next => next;

    public ExtraLinkedListNode<T>? Previous => previous;
}
