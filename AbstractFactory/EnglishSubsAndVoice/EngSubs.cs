using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class EngSubs : IEngSubs
    {
        public string AppendEngSubs()
        {
            return "english voice acting";
        }

        public string SetEngSubs(IEngVoice voice)
        {
            var result = voice.AppendEngVoice();

            return $"English voice with {result}";
        }
    }
}
