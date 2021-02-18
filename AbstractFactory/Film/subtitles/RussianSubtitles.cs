using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.subtitle
{
    public class RussianSubtitles : ISubtitle
    {
        public string Play()
        {
            return "Russian subtitles";
        }
    }
}
