using System;

namespace JasonPereira84.Result
{
    public partial struct Result<TError, TValue>
    {
        internal static Result<TError, TValue> from(Nullable<Boolean> overall, TError error, TValue value)
            => new Result<TError, TValue>
            {
                Overall = overall,
                Error = error,
                Value = value
            };

        public static Result<TError, TValue> FromUnknown(TError error = default(TError), TValue value = default(TValue))
            => from(null, error, value);

        public static Result<TError, TValue> FromFailure(TError error, TValue value = default(TValue))
            => from(false, error, value);

        public static Result<TError, TValue> FromSuccess(TValue value, TError error = default(TError))
            => from(true, error, value);
    }

}