using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = "Pesho";
            person1.Age = 20;
            person2.Name = "Gosho";
            person2.Age = 18;
            person3.Name = "Stamat";
            person3.Age = 43;

            person1.IntroduceYoursel();
            person2.IntroduceYoursel();
            person3.IntroduceYoursel();
        }
    }
}
