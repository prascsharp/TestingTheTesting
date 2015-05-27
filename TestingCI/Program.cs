using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCI
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding 1 and 2 results {0}", new Calculator().Add(1, 2));
        }
    }
}
