using System;
namespace recordDemo
{
    class Program
    {
        public record Person(int Id, string Title, string Author, double Price);

        public static void Main()
        {
            Person person = new(1564, "What Do You Call A Mouse?", "Sam P. Martha", 12.56);
            Console.WriteLine(person);

            Person person1 = new(1584, "I know How To Climb A Tree", "Kyle L. Remmy", 9.99);
            Console.WriteLine(person1);

            Person person2 = new(1647, "Love Is In The Air", "Peiar J. Bix", 10.59);
            Console.WriteLine(person2);

        }
    }
}
