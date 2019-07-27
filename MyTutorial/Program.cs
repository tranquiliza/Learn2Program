using System;

namespace MyTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var _rnd = new Random();

            var number = _rnd.Next();

            Console.WriteLine(number);
            Console.Read();
        }
    }
}
