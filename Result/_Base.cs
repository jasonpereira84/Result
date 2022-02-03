using System;

namespace JasonPereira84.Result
{
    public partial struct Result<TError, TValue>
    {
        public Nullable<Boolean> Overall { get; internal set; }

        public TError Error { get; internal set; }

        public TValue Value { get; internal set; }
    }

}