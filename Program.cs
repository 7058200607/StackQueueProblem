using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProblem
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do Stack Operation!");
            StackQueue stacksProblem = new StackQueue();
            stacksProblem.push(70);
            stacksProblem.push(30);
            stacksProblem.push(56);
            stacksProblem.display();

        }
    }
}

