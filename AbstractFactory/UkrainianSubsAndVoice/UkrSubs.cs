using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class UkrSubs : IUkrSubs
    {
        public string AppendUkrSubs()
        {
            return "ukrainian voice acting";
        }

        public string SetUkrSubs(IUkrVoice voice)
        {
            var result = voice.AppendUkrVoice();

            return $"Ukrainian voice with {result}";
        }
    }
}
