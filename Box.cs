using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T str;

        public T Str { get; }
        public Box(T strings)
        {
            this.Str = strings;
        }

        public override string ToString()
        {
            return $"{Str.GetType()}: {Str}";
        }
    }
}
