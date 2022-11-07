using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapStringBox
{
    internal class SwapString<T>
    {
        private T str;

        public T Str { get; }

        public SwapString(T strings)
        {
            this.Str = strings;
        }

        public override string ToString()
        {
            return $"{Str.GetType()}: {Str}";
        }
    }
}
