using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.subtitle
{
    public class EnglishSubtitles : ISubtitle
    {
        public string Play()
        {
            return "English subtitles";
        }
    }
}
