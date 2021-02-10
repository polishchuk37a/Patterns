using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public interface IEngSubs
    {
        string AppendEngSubs();

        string SetEngSubs(IEngVoice voice);
    }
}
