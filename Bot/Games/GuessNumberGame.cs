using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Games
{
    public class GuessNumberGame
    {
        public bool IsPlaying;
        int Number;

        public void Start()
        {
            IsPlaying = true;

            Random r = new Random();
            Number = r.Next(1, 100);
            Console.WriteLine("Игра началась! Я загадал число от 1 до 100, угадай какое!");
        }

        public void Finish()
        {
            IsPlaying = false;
            Console.WriteLine("Игра окончена!");
        }

        public void MakeTurn(string message)
        {
            try
            {
                int guess = Convert.ToInt32(message);

                if (guess == Number)
                {
                    Console.WriteLine($"Угадал! Я загадывал число {Number}!");
                    Finish();
                    return;
                }

                if (guess < Number)
                {
                    Console.WriteLine("Нет, моё число больше!");
                }
                else
                {
                    Console.WriteLine("Нет, моё число меньше!");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Нет! Введи число!");
            }
        }
    }
}
