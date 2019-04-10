using System;

namespace CppSharp.Runtime
{
    public class Pointer<T>
    {
        private readonly IntPtr ptr;

        public Pointer(IntPtr ptr)
        {
            this.ptr = ptr;
        }

        public static implicit operator IntPtr(Pointer<T> pointer)
        {
            return pointer.ptr;
        }
    }
}
