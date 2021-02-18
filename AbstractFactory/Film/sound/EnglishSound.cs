using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.soundtrack
{
    public class EnglishSound : ISound
    {
        public string Play()
        {
           return "English sound";
        }
    }
}
