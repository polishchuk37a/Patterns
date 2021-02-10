using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class UkrVoice : IUkrVoice
    {
        public string AppendUkrVoice()
        {
            return "ukrainian voice acting";
        }

        public string SetUkrVoice(IUkrSubs subs)
        {
            var result = subs.AppendUkrSubs();

            return $"Ukrainian voice with {result}";
        }
    }
}
