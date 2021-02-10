using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public interface IEngVoice
    {
        public string AppendEngVoice();

        public string SetEngVoice(IEngSubs subs);
    }
}
