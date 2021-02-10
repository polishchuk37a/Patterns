using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public interface IUkrVoice
    {
        public string AppendUkrVoice();

        public string SetUkrVoice(IUkrSubs subs);
    }
}
