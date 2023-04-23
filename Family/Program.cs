using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi br. clenove: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person person1 = new Person();                 // string[] name = Console.ReadLine().Split();
                Console.Write("Vavedi ime: ");
                person1.Name = Console.ReadLine();
                Console.Write("Vavedi godini: ");
                person1.Age = int.Parse(Console.ReadLine());
                person1.Print();
            }
        }
    }
}
