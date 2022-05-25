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
    }
}