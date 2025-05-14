using System.Collections;

namespace DataStructures;

public class ExtraLinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerator<T>, IDisposable
{
    private ExtraLinkedListNode<T>? head = null;
    private ExtraLinkedListNode<T>? tail = null;
    private ExtraLinkedListNode<T>? current = null;
    private int count = 0;

    public ExtraLinkedList()
    {            
    }

    public ExtraLinkedList(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            AddLast(item);
        }
    }

    public ExtraLinkedListNode<T> AddFirst(T value)
    {
        var newNode = new ExtraLinkedListNode<T>(value);
        AddFirst(newNode);

        return newNode;
    }

    public void AddFirst(ExtraLinkedListNode<T> newNode)
    {
        if (head is null)
        {
            head = newNode;
        }
        else
        {
            newNode.next = head;
            head.previous = newNode;
            head = newNode;
        }

        if (tail is null)
        {
            tail = newNode;
        }

        count++;
    }

    public ExtraLinkedListNode<T> AddAfter(ExtraLinkedListNode<T> node, T value)
    {
        var newNode = new ExtraLinkedListNode<T>(value);
        AddAfter(node, newNode);

        return newNode;
    }

    public void AddAfter(ExtraLinkedListNode<T> node, ExtraLinkedListNode<T> newNode)
    {
        var next = node.Next;
        node.next = newNode;
        newNode.previous = node;
        if (next is not null)
        {
            newNode.next = next;
            next.previous = newNode;
        }
        else
        {
            tail = newNode;
        }

        count++;
    }

    public ExtraLinkedListNode<T> AddLast(T value)
    {
        var newNode = new ExtraLinkedListNode<T>(value);
        AddLast(newNode);

        return newNode;
    }

    public void AddLast(ExtraLinkedListNode<T> newNode)
    {
        if (tail is null)
        {
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            newNode.previous = tail;
            tail = newNode;
        }

        if (head is null)
        {
            head = newNode;
        }
        
        count++;
    }

    public ExtraLinkedListNode<T> AddBefore(ExtraLinkedListNode<T> node, T value)
    {
        var newNode = new ExtraLinkedListNode<T>(value);
        AddBefore(node, newNode);

        return newNode;
    }

    public void AddBefore(ExtraLinkedListNode<T> node, ExtraLinkedListNode<T> newNode)
    {
        var previous = node.Previous;
        node.previous = newNode;
        newNode.next = node;
        if (previous is not null)
        {
            previous.next = newNode;
            newNode.previous = previous;
        }
        else
        {
            head = newNode;
        }

        count++;
    }

    public ExtraLinkedListNode<T> Find(T value)
    {
        var current = head;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                return current;
            }
            current = current.Next;
        }

        return null;
    }

    public T Current => current.Value;

    public int Count => count;

    public bool IsReadOnly => false;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        Reset();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (current is null)
        {
            current = head;
            return true;
        }

        if (current?.Next is not null)
        {
            current = current.Next;
            return true;
        }

        return false;
    }

    public bool Contains(T value) => Find(value) is not null;

    public void Reset()
    {
        current = head;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        AddFirst(item);
    }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        var current = head;
        for (var i = arrayIndex; i < array.Length; i++)
        {
            if (current is null)
            {
                break;   
            }

            array[i] = current.Value;
            current = current.Next; 
        }
    }

    public bool Remove(T item)
    {
        var node = Find(item);

        if (node is not null)
        {
            node.previous.next = node.Next;
            node = null;
            count--;

            return true;
        }

        return false;
    }
}
