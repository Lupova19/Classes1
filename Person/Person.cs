using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name { get; set; }
        public int Age { get; set; }

        public void IntroduceYoursel()
        {
            Console.WriteLine($"Аз съм {this.Name} и съм на {this.Age}!");
        }
    }
}
