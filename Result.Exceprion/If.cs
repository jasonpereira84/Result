using System;

namespace JasonPereira84.Result
{
    public partial class ResultException<TException, TValue> : Exception
        where TException : Exception
    {
        public TReturn If<TReturn>(
            Func<TException, TValue, TReturn> onSuccess,
            Func<TException, TValue, TReturn> onFailure,
            Func<TException, TValue, TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke(Error, Value);

        public void If(
            Action<TException, TValue> onSuccess,
            Action<TException, TValue> onFailure,
            Action<TException, TValue> onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke(Error, Value);
    }

}