using System;

namespace JasonPereira84.Result
{
    public partial class ResultException<TException, TValue> : Exception
        where TException : Exception
    {
        internal static ResultException<TException, TValue> from(Nullable<Boolean> overall, TException error, TValue value)
            => new ResultException<TException, TValue>(overall, error, value) { };

        public static ResultException<TException, TValue> FromUnknown(TException error, TValue value)
            => from(null, error, value);

        public static ResultException<TException, TValue> FromFailure(TException error, TValue value)
            => from(false, error, value);

        public static ResultException<TException, TValue> FromSuccess(TValue value, TException error)
            => from(true, error, value);
    }

}