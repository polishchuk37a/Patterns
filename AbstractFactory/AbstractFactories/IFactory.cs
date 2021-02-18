using AbstractFactoryFilms.filmStrip.soundtrack;
using AbstractFactoryFilms.filmStrip.subtitle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.factories
{
    public interface IFactory
    {
        ISound Sound();
        ISubtitle Subtitle();
    }
}
