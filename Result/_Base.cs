using System;

namespace JasonPereira84.Result
{
    public partial class Result<TError, TValue>
    {
        public Nullable<Boolean> Overall { get; internal set; }

        public TError Error { get; internal set; }

        public TValue Value { get; internal set; }

        internal Result(Boolean? overall, TError error, TValue value)
        {
            Overall = overall;
            Error = error;
            Value = value;
        }

        internal Result(TError error, TValue value) : this(null, error, value) { }

        internal Result(TError error) : this(null, error, default(TValue)) { }

        internal Result(TValue value) : this(null, default(TError), value) { }

        internal Result() : this(null, default(TError), default(TValue)) { }

    }

}