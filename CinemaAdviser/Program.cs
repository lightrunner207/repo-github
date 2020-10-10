using System;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, друг! Эта программа поможет тебе подобрать фильм на вечер!");
            Console.WriteLine("Как тебя зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);
            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть? Комедия, драма или фантастика?");
            string genre = Console.ReadLine();
            if (genre == "комедия") {
                Console.WriteLine("Pulp Fiction - yor choice");
            } else if (genre == "драма") {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sex Education - your choice");
            } else if (genre == "фантастика") {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Люди икс норм так фильм");
            } else {
                Console.WriteLine("You are sick");
            }

            Console.ReadLine();

        }
    }
}
