using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Person
    {


        public string name;
        public int age;

        public Person()
        {
            name = "none";
            age = 18;

        }


        public Person(string name, int age)
        {

            this.name = name;
            this.age = age;

        }

        public void GetInfo()
        {

            Console.WriteLine($"Name: {name} Age: {age}");

        }
    }
}
