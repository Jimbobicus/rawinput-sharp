using System;
using Linearstar.Windows.RawInput;

namespace Linearstar.Windows.RawInput
{
    public sealed class RawInputEventArgs : EventArgs
    {
        public RawInputData Data { get; }
        public IntPtr Param { get; }

        public RawInputEventArgs() : this(null, IntPtr.Zero) {}
        public RawInputEventArgs(RawInputData data) : this(data, IntPtr.Zero) { }
        public RawInputEventArgs(RawInputData data, IntPtr param)
        {
            Data = data;
            Param = param;
        }
    }
}
