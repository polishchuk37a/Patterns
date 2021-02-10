using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class RusSubs : IRusSubs
    {
        public string AppendRusSubs()
        {
            return "russian voice subtitles";
        }

        public string SetRusSubs(IRusVoice voice)
        {
            var result = voice.AppendRusVoice();

            return $"Russian subtitles with {result}";
        }
    }
}
