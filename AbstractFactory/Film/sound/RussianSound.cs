using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.soundtrack
{
    public class RussianSound : ISound
    {
        public string Play()
        {
            return "Russian sound";
        }
    }
}
