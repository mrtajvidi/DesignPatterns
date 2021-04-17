using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            return string.Join(",", _parts);
        }
    }
}