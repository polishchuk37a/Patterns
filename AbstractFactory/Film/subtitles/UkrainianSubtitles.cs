using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFilms.filmStrip.subtitle
{
    public class UkrainianSubtitles : ISubtitle
    {
        public string Play()
        {
            return "Ukrainian subtitles";
        }
    }
}
