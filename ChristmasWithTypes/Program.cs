using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //TODO set Santa's name to Kris Kringle
            xmas.Kris Kringle = null;

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents = 'Xbox'; "Ninetendo Switch", "Iphone" 3]{ }; 

            //TODO Set the TreeHeight to 10
            xmas.TreeHeight = null;

            Console.WriteLine($"This year christmas falls on {christmas}");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} 10 feet high \n");
            Console.WriteLine("Here are the presents we would like:\"Xbox[\", \"Ninetendo Switch\", \"Iphone\"");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
