using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class RusVoice : IRusVoice
    {
        public string AppendRusVoice()
        {
            return "russian voice acting";
        }
        public string SetRusVoice(IRusSubs subs)
        {
            var result = subs.AppendRusSubs();

            return $"Russian voice with {result}";
        }
    }
}
