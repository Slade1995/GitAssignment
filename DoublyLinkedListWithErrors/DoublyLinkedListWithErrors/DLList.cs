using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {

            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.previous = tail;
                tail.next = p;
                tail = p;
                
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
              
            }
        } // end of addToHead

        public void removeHead()
        {
            if (head == null) return;
            if(head == tail)
            {
                head = null;
                tail = null;
            }
            else if (head != null)
            {
                head = head.next;
                head.previous = null;
            }
        } // removeHead

        public void removeTail()
        {
            if (tail == null) return;
            if (head == tail)
            {
                head = null;
                tail = null;

            }
            else if (tail != null)
            {
                tail = tail.previous;
                tail.next = null;
            }
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            DLLNode p = head;
            while (p != null)
            {
                if (p.num == num) return p;
                p = p.next;
            }
            return null;
        } // end of search (return pointer to the node);

        public void removeNode(DLLNode p)
        { // removing the node p.

            if (p == null) return;
            if (p.next == null)
            {
                tail = tail.previous;
                if (tail != null)
                    tail.next = null;
            }
            else if (p.previous == null)
            {
                head = head.next;
                if (head != null)
                    head.previous = null;
            }
            else
            {
                p.next.previous = p.previous;
                p.previous.next = p.next;
            }
        } // end of remove a node 

        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return (tot);
        } // end of total
    } // end of DLList class
}
