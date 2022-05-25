using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProblem
{
    public class StackQueue
    {

        public Node top;
        public StackQueue()
        {
            this.top = null;

        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top != null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("pushed into stack{0}", value);


        }
        internal void display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty :");
                return;
                Console.WriteLine("{0} top Element of the Stack", this.top.data);

            }
        }
        internal void pop()
        {
            {
                if (this.top == null) ;
                Console.WriteLine("Stack is Empty ,Deletion is not Possible");
                return;

            }
            Console.WriteLine("value pop is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }

        }

    }
}