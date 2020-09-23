using System;

namespace JasonPereira84.Result
{
    public interface IResult
    {
        Nullable<Boolean> Overall { get; }
    }

    public interface IResult<TError> : IResult
    {
        TError Error { get; }
    }

    public interface IResult<TError, TValue> : IResult<TError>
    {
        TValue Value { get; }
    }
}