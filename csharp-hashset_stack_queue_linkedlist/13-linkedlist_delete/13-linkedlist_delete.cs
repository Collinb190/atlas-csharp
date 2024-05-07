using System;
using System.Collections.Generic;

class LList
{
   public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> result = myLList.First;
        int counter = 0;
        while(result != null)
        {
            if (counter == index)
                myLList.Remove(result);
            counter += 1;
            result = result.Next;
        }
    }
}
