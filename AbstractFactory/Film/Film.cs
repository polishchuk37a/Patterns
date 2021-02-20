using AbstractFactoryFilms.factories;
using AbstractFactoryFilms.filmStrip.soundtrack;
using AbstractFactoryFilms.filmStrip.subtitle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms
{
    public class Film
    {
        private ISound sound;
        private ISubtitle subtitle;

        public Film(IFactory factory)
        {
            if (factory != null)
            {
                sound = factory.Sound();
                subtitle = factory.Subtitle();
            }
        }

        public void play()
        {
            if (sound != null && subtitle != null)
            {

                Console.WriteLine(sound.Play());
                Console.WriteLine(subtitle.Play());
            }
        }
    }
}
