using System;

namespace DesignPatterns.CreationalPatterns
{
    public class Monostate
    {
        private static readonly Dictionary<string, string> _state = new Dictionary<string, string>();

        public void SetValue(string key, string value)
        {
            _state[key] = value;
        }

        public string GetValue(string key)
        {
            return _state.ContainsKey(key) ? _state[key] : null;
        }
    }
}
