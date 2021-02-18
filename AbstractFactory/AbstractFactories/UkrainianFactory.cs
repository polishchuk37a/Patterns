using AbstractFactoryFilms.filmStrip.soundtrack;
using AbstractFactoryFilms.filmStrip.subtitle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.factories
{
    public class UkrainianFactory : IFactory
    {
        public ISound Sound()
        {
            return new UkrainianSound();
        }

        public ISubtitle Subtitle()
        {
           return new UkrainianSubtitles();
        }
    }
}
