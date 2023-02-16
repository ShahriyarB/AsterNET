using System.Collections.Generic;

namespace AsterSharp.Manager
{
    /// <summary>
    ///     IActionVariable
    /// </summary>
    interface IActionVariable
    {
        Dictionary<string, string> GetVariables();
        void SetVariables(Dictionary<string, string> vars);
    }
}
