using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class Client
    {
        public void Main()
        {
            int choice;
            string film = "";

            do
            {
                Console.WriteLine("Choose the film (1-FilmA; 2-FilmB; 3-FilmC): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        film = "filmA";
                        break;
                    case 2:
                        film = "filmB";
                        break;
                    case 3:
                        film = "filmC";
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Choose voice acting and subtitles will be set automatically (1-Rus; 2-Ukr; 3-Eng): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your choice is {film}("+new RusVoice().SetRusVoice(new RusSubs())+").");
                        break;
                    case 2:
                        Console.WriteLine($"Your choice is {film}(" + new UkrVoice().SetUkrVoice(new UkrSubs()) + ").");
                        break;
                    case 3:
                        Console.WriteLine($"Your choice is {film}(" + new EngVoice().SetEngVoice(new EngSubs()) + ").");
                        break;
                    default:
                        break;
                }              
            } while (true);
        }
    }
}