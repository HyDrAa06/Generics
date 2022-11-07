using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapIntBox
{
    internal class SwapInt<T>
    {
        private T integer;

        public T Integer { get; }

        public SwapInt(T integer)
        {
            this.Integer = integer;
        }

        public override string ToString()
        {
            return $"{Integer.GetType()}: {Integer}";
        }
    }
}
