using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class IntegerLinkedList
    {
        /// <summary>
        /// creating a new node and an 
        /// int value
        /// </summary>
        private class Node
        {           
            public int value;
            public Node next;
           

            /// <summary>
            /// a constructor for the node
            /// setting default values
            /// </summary>
            /// <param name="v"></param>
            public Node(int v)
            {
                value = v;
                next = null;
            }
        }

        private int count;
        private Node start;
        

        /// <summary>
        /// setting a read only count to hold how
        /// many numbers are being stored
        /// </summary>
        public int Count
        {
            get
            { return count; }
        }

        /// <summary>
        /// constructor for count and the 
        /// node called start setting default values
        /// </summary>
        public IntegerLinkedList()
        {
            count = 0;
            start = null;
        }


        /// <summary>
        /// creates a new node and adds the 
        /// value into the start of the list
        /// </summary>
        /// <param name="v"></param>
        public void addFirst(int v)

        {
            Node n = new Node(v);
            count++;

            if (start == null)
            {
                start = n;
            }
            else
            {
                n.next = start;
                start = n;
            }
        }

        /// <summary>
        /// creates a new node and adds it to 
        ///the last node that was created
        /// </summary>
        /// <param name="v"></param>
        public void addLast(int v)

        {
            Node n = new Node(v);
            Node current = start;

            if (start == null)
            {
                start = n;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = n;
            }
            count++;
        }


        /// <summary>
        /// removes from the count and
        /// also removes the value from the
        /// first node
        /// </summary>
         public int removeFirst()
        {
            int value = 0;
            if (isEmpty())
            {
                throw new Exception("empty");
            }

            else
            {
                start = start.next;
                count--;
                return value;
            }
          

        }


        /// <summary>
        /// finds the last node in the list 
        /// and removes it.
        /// </summary>

        public int removeLast()
            {

            if (isEmpty())
            {

                throw new Exception("empty");
            }
            int value = 0;
            Node curr = start;
            while (curr.next != null)
            {

                curr = curr.next;

            }
         
            {
                start = start.next;             
               
            }
           
  
            count--;
            return value;
        }


        /// <summary>
        /// clears all nodes and resets 
        /// the count
        /// </summary>
         public void destroy()
        {
            start = null;
            count = 0;
        }


        /// <summary>
        /// returns a true or false
        /// depending on weather there is 
        /// a value or not
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (count == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// displays the UI
        /// </summary>
        public void displayUI()
        {
            Node disp = start;
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine(disp.value);
                disp = disp.next;

            }
        }

        /// <summary>
        /// inserts a value and sorts to highest
        /// or lowest number
        /// </summary>
        /// <param name="value"></param>
        public void insert(int value)
            
        {
            Node current = start;
            Node previous = null;

            Node temp = new Node(value);
            temp.value = value;
            temp.next = null;

            while (current != null && current.value <value )
            {
                previous = current;
                current = current.next;
            }

            if (start == current)
            {
                start = temp;
                temp.next = current;
            }

            else if (current == null || current.value != value)
                previous.next = temp;
            temp.next = current;
        }
    }

}









        
    



    

