using AbstractFactoryFilms.filmStrip.soundtrack;
using AbstractFactoryFilms.filmStrip.subtitle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.factories
{
    public class EnglishFactory : IFactory
    {
        public ISound Sound()
        {
            return new EnglishSound();
        }

        public ISubtitle Subtitle()
        {
            return new EnglishSubtitles();
        }
    }
}
