using System;
using System.Collections.Generic;

class LList
{
   public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> result = myLList.First;
        while(result != null)
        {
            if (result.Value < n)
                result = result.Next;
            else
            {
                myLList.AddBefore(result, n);
                return myLList.First;
            }
        }
        myLList.AddLast(n);
        return myLList.First;
    }
}
