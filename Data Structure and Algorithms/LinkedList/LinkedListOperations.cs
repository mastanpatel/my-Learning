using System;

namespace LinkedList
{

    //we need a node with data and address for implelemting Linked list

    class node
    {
        public int data { get; set; }

        public node next;

        public node(int data)
        {
            this.data = data;
        }
    }
    class LinkedListOperations
    {

        //LL is continuos block of memory
        //LL is refrence type in c#

        //operations performed on LL
        //1. insertion
        //2. update
        //3. deletion
        //4. transversal

        //cost of each kind of operation
        //1. insertion -> insertion in the end is O(n) where n-> number of shift done but insertion in the begining is less O(1).
        //2. update -> update at perticular location is O(n)
        //3. deletion -> deletion is also efficient at perticular location O(n)
        //4. tranversal -> traversal is also O(n)

        //we need to create a head node
        public node Head;

        public LinkedListOperations()
        {
            Head = null;
        }


        /// <summary>
        /// insert the node in the begining of LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void insertElementBegin(int data)
        {
            //create a new node to add new node
            node newNode = new node(data);

            newNode.next = Head;
            newNode.data = data;
            Head = newNode;
            
        }

        /// <summary>
        /// insert element inbetween the list
        /// </summary>
        /// <param name="data"></param>
        /// <param name="insertBefore"></param>
        public void insertElementInbetween(int data,int ? insertBefore = null)
        {
            if (insertBefore == null)
            {
                return;
            }
            else
            {
                node newNode = new node(data);
                node temp = Head;
                node prevNode = Head;

                while (temp.data != insertBefore)
                {
                    prevNode = temp;
                    temp = temp.next;
                }

                newNode.next = prevNode.next;
                prevNode.next = newNode;

                newNode.data = data;
            }
        }

        /// <summary>
        /// delete an element form LinkedList
        /// </summary>
        /// <param name="numberTodelete"></param>
        public void deleteElement(int numberTodelete)
        {
            node temp = Head;
            node nextNode = Head;
            node prevNode = Head;

            while (temp.data != numberTodelete)
            {
                prevNode = temp;
                temp = temp.next;
                nextNode = temp;
            }

            prevNode.next = nextNode.next;
            nextNode.next = null;

        }


        public void deleteList()
        {
            Head = null;
        }
        /// <summary>
        /// Prints the LinkedList 
        /// </summary>
        public void PrintList()
        {
            node temp;

            temp = Head;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }



    }
}
