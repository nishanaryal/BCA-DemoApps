using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Multiple Inheritance can be achieved in C# using Interfaces.
This is the simple mathematical operation program demonstrating how multiple inheritance can be achieved in C# using Interface Concept.
*/
namespace BankAppCA
{
    interface calc1
    {
        int add(int a, int b);
    }
    interface calc2
    {
        int sub(int x, int y);
    }
    interface calc3
    {
        int mul(int r, int s);
    }
    interface calc4
    {
        int div(int c, int d);
    }
    class MultipleInheritanceDemo : calc1, calc2, calc3, calc4
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }

        class Program
        {
            static void Main(string[] args)
            {
                MultipleInheritanceDemo c = new MultipleInheritanceDemo();
                c.add(8, 2);
                c.sub(20, 10);
                c.mul(5, 2);
                c.div(20, 10);
                Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
                Console.WriteLine("Addition: " + c.result1);
                Console.WriteLine("Substraction: " + c.result2);
                Console.WriteLine("Multiplication :" + c.result3);
                Console.WriteLine("Division: " + c.result4);
                Console.ReadKey();
            }
        }
    }
}
