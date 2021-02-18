  using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.soundtrack
{
    public class UkrainianSound : ISound
    {
        public string Play()
        {
           return "Ukrainian sound";
        }
    }
}
