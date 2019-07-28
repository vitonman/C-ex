using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //CycleClass cycleclass = new CycleClass();
            //cycleclass.GetForCycle();


            Person person = new Person();
            person.GetInfo();

            person.name = "Vitali";
            person.age = 25;
            person.GetInfo();

            Person second_person = new Person("Vitali2", 25);
            second_person.GetInfo();

            Console.ReadKey();

            
        }


    }

    class Person
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
