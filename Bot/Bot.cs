using Bot.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot
{
    class Bot
    {
        public string Name;

        public bool IsWorking = false;

        GuessNumberGame game = new GuessNumberGame();
        public void Greetings()
        {
            Console.WriteLine("Привет, меня зовут " + Name + "!");
            Console.WriteLine("Очень рад тебя видеть!");

        }
        public void StartMainLoop()
        {
            game.Start();
            IsWorking = true;
            while (IsWorking)
            {
                var message = Console.ReadLine();

                if (game.IsPlaying)
                {
                    game.MakeTurn(message);
                }
                else
                {
                Console.WriteLine(Answer());

                }
            }
        }

        string Answer()
        {
            List<string> lines = new List<string>()
            {
                "Я на 40% титановый (из удачи, из цинка, доломитовый и т.д.)",
                "Я спас черепаху. А что сделали вы?",
                "Вы можете сказать, что я болтаю ерунду. Зато какую!",
                "Как и многие жизненные проблемы, эту можно решить сгибанием.",
                "Качание, это всего лишь примитивная разновидность сгибания!"

            };

            Random r = new Random();
            return lines[r.Next(0, lines.Count)];
        }
    }
}
