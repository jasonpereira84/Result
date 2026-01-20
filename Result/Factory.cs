using System;

namespace JasonPereira84.Result
{
    public partial class Result<TError, TValue>
    {
        internal static Result<TError, TValue> from(Nullable<Boolean> overall, TError error, TValue value)
            => new Result<TError, TValue>(overall, error, value);

        public static Result<TError, TValue> FromUnknown(TError error = default(TError), TValue value = default(TValue))
            => new Result<TError, TValue>(null, error, value);

        public static Result<TError, TValue> FromFailure(TError error, TValue value = default(TValue))
            => new Result<TError, TValue>(false, error, value);

        public static Result<TError, TValue> FromSuccess(TValue value, TError error = default(TError))
            => new Result<TError, TValue>(true, error, value);
    }

}