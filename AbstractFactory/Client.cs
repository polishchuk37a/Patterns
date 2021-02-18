using AbstractFactoryFilms.factories;
using AbstractFactoryFilms.filmStrip;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms
{
    public class Client
    {     
        public void Main()
        {
            int choice;
            do
            {
                Console.Write("Select language: \n 1-Russian \n 2-English \n 3-Ukrainian \n 4-Exit \n Your choice is: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            ClientMethod(new RussianFactory());
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            ClientMethod(new EnglishFactory());
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            ClientMethod(new UkrainianFactory());
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
            } while (choice != 4);       
        }

        public void ClientMethod(IFactory factory)
        {         
            Console.WriteLine(factory.Sound().Play());
            Console.WriteLine(factory.Subtitle().Play());
        }
    }
}
