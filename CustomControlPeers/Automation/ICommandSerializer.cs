using System;
using System.Collections.Generic;

namespace White.CustomControls.Peers.Automation
{
    public interface ICommandSerializer
    {
        bool TryDeserialize(string @string, out ICommand command);
        string Serialize(object o, List<Type> knownTypes);
    }
}