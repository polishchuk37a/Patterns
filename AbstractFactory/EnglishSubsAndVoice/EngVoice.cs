using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class EngVoice : IEngVoice
    {
        public string AppendEngVoice()
        {
            return "english voice acting";
        }

        public string SetEngVoice(IEngSubs subs)
        {
            var result = subs.AppendEngSubs();

            return $"English voice with {result}";
        }
    }
}
