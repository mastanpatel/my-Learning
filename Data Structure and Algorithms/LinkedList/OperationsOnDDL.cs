using System;

namespace LinkedList
{

    class DLLnode
    {
        public int data { get; set; }

        public DLLnode next { get; set; }

        public DLLnode prev { get; set; }

        public DLLnode(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }

    class OperationsOnDDL
    {
        public DLLnode Head { get; set; }
         
        //operations performed on LL
        //1. insertion
        //2. update
        //3. deletion
        //4. transversal

        //insertion in the begining of DLL
        public void push(int data)
        {
            DLLnode node = new DLLnode(data);

            if (Head == null)
            {
   
                Head = node;
                
            }
            else
            {
                node.next = Head;
                node.prev = null;
                Head.prev = node;
                Head = node;
            }
            

            //data
            node.data = data;
        }


        public void addBeforeNode(DLLnode nextNode, int data)
        {
            if (nextNode == null)
            {
                Console.WriteLine("There is no Previous node.");
                return;
            }

            DLLnode node = new DLLnode(data);

            node.next = nextNode;
            node.prev = nextNode.prev;
            nextNode.prev.next = node;
            nextNode.prev = node;

            node.data = data;
        }


        public void addAfterNode(DLLnode afterNode, int data)
        {
            if (afterNode == null)
            {
                Console.WriteLine("There is no Previous node.");
                return;
            }

            DLLnode node = new DLLnode(data);

            node.next = afterNode.next;
            node.prev = afterNode;
            node.next.prev = node;
            afterNode.next = node;
            

            node.data = data;
        }



        public void PrintList()
        {
            DLLnode temp = Head;

            while (temp != null)
            {
                Console.Write(temp.data + " ");

                temp = temp.next;
            }
        }

    }
}
