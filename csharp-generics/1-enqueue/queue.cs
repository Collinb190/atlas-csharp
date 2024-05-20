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
        private T value = null;
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
            tail.next = temp;
            tail = temp;
        }
        count ++;
    }

    public int Count()
    {
        return count;
    }
}
