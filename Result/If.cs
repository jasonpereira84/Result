using System;

namespace JasonPereira84.Result
{
    public partial struct Result<TError, TValue>
    {
        public TReturn If<TReturn>(
            Func<TError, TValue, TReturn> onSuccess,
            Func<TError, TValue, TReturn> onFailure,
            Func<TError, TValue, TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke(Error, Value);

        public void If(
            Action<TError, TValue> onSuccess,
            Action<TError, TValue> onFailure,
            Action<TError, TValue> onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke(Error, Value);
    }

}