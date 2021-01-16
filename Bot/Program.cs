using System;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bender = new Bot();
            bender.Name = "Бендер";
            bender.Greetings();
            bender.StartMainLoop();

        }
    }
}