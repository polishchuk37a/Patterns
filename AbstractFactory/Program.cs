using AbstractFactoryFilms.factories;
using AbstractFactoryFilms.filmStrip;
using System;

namespace AbstractFactoryFilms
{
    class Program
    {
        private static int choice = 0;
        static void Main(string[] args)
        {
            do
            {
                Film film = GetFilm();
                if (film != null)
                {               
                    film.play();
                }
                Console.WriteLine();
            } while (choice != 4);
        }

        public static Film GetFilm()
        {        
            IFactory factory = null;

            do
            {
                Console.Write("Select language: \n 1-Russian \n 2-English \n 3-Ukrainian \n 4-Exit \n Your choice is: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            factory = new RussianFactory();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            factory = new EnglishFactory();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            factory = new UkrainianFactory();
                            Console.WriteLine();
                            break;
                        }
                }

            } while (choice <= 0 || choice > 4);
            return new Film(factory);
        }
    }
}

