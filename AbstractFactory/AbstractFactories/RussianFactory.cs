using AbstractFactoryFilms.filmStrip.soundtrack;
using AbstractFactoryFilms.filmStrip.subtitle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.factories
{
    public class RussianFactory : IFactory
    {
        public ISound Sound()
        {
            return new RussianSound();
        }

        public ISubtitle Subtitle()
        {
            return new RussianSubtitles();
        }
    }
}
