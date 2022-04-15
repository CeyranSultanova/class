using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person("Ceyran", "Sultanova",22);
            Person person2 = new Person("Ceyran1", "Sultanova2");

            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Name);
           
            //Person person2 = new Person("Ceyran", "Sultanova", 2);
        
            //Console.WriteLine(person1.Age);
            //Console.WriteLine(person2.Age);

        }
    }

}
