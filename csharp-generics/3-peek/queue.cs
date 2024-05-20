using System;

class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    /// <summary>
    /// Checks type
    /// </summary>
    /// <returns>type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Node class inside of Queue
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T param)
        {
            value = param;
        }
    }

    public void Enqueue(T value)
    {
        Node vari = new Node(value);

        if (head == null)
        {
            head = vari;
            tail = vari;
        }
        else
        {
            tail.next = vari;
            tail = vari;
        }
        count ++;
    }

    public T Dequeue()
    {
        Node vari = head;
        if (vari == null)
        {
            Console.WriteLine("Queue is emtpy");
            return default(T);
        }
        head = head.next;
        count --;
        return vari.value;
    }

    public int Count()
    {
        return count;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }
}
