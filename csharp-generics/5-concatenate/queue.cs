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

    public void Print()
    {
        Node vari = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        while (vari != null)
        {
            Console.WriteLine($"{vari.value}");
            vari = vari.next;
        }
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only");
            return null;
        }

        string result = "";
        Node vari = head;
        bool stopper = true;

        while (vari != null)
        {
            if (stopper != true && typeof(T).Name == "String")
                result += " ";
            result += vari.value;
            vari = vari.next;
            stopper = false;
        }
        return result;
    }
}
