using System;

namespace JasonPereira84.Result
{
    public interface IResult
    {
        Nullable<Boolean> Overall { get; }
    }
    public partial class Result : IResult
    {
        public Nullable<Boolean> Overall { get; internal set; }

        internal Result(Boolean? overall) => Overall = overall;

        internal Result(): this(null) { }
    }

    public interface IResult<TValue> : IResult
    {
        TValue Value { get; }
    }
    public partial class Result<TValue> : Result, IResult<TValue>
    {
        public TValue Value { get; internal set; }

        internal Result(Boolean? overall, TValue value) : base(overall) => Value = value;

        protected internal Result(TValue value): this(null, value) { }

        protected internal Result() : this(default) { }
    }

    public interface IResult<TValue, TError> : IResult<TValue>
    {
        TError Error { get; }
    }
    public partial class Result<TValue, TError> : Result<TValue>, IResult<TValue, TError>
    {
        public TError Error { get; internal set; }

        internal Result(Boolean? overall, TValue value, TError error) : base(overall, value) => Error = error;

        protected internal Result(TValue value, TError error) : this(null, value, error) { }

        protected internal Result(TValue value) : this(value, default) { }

        protected internal Result(TError error) : this(default, error) { }

        protected internal Result() : this(default(TError)) { }
    }

}