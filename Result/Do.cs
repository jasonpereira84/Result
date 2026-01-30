using System;

namespace JasonPereira84.Result
{
    public partial class Result
    {
        public TReturn Do<TReturn>(
            Func<TReturn> onSuccess,
            Func<TReturn> onFailure,
            Func<TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke();

        public void Do(
            Action onSuccess,
            Action onFailure,
            Action onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke();
    }

    public partial class Result<TValue>
    {
        public TReturn Do<TReturn>(
            Func<TValue, TReturn> onSuccess,
            Func<TValue, TReturn> onFailure,
            Func<TValue, TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke(Value);
        private new TReturn Do<TReturn>(
            Func<TReturn> onSuccess,
            Func<TReturn> onFailure,
            Func<TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke();

        public void Do(
            Action<TValue> onSuccess,
            Action<TValue> onFailure,
            Action<TValue> onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke(Value);
        private new void Do(
            Action onSuccess,
            Action onFailure,
            Action onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke();
    }

    public partial class Result<TValue, TError>
    {
        public TReturn Do<TReturn>(
            Func<TValue, TError, TReturn> onSuccess,
            Func<TValue, TError, TReturn> onFailure,
            Func<TValue, TError, TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke(Value, Error);
        private new TReturn Do<TReturn>(
            Func<TValue, TReturn> onSuccess,
            Func<TValue, TReturn> onFailure,
            Func<TValue, TReturn> onUnknown)
            => (IsUnknown ? onUnknown
                : IsFailure ? onFailure
                    : onSuccess).Invoke(Value);

        public void Do(
            Action<TValue, TError> onSuccess,
            Action<TValue, TError> onFailure,
            Action<TValue, TError> onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke(Value, Error);
        private new void Do(
            Action<TValue> onSuccess,
            Action<TValue> onFailure,
            Action<TValue> onUnknown)
            => (IsUnknown ? onUnknown
                    : IsFailure ? onFailure
                        : onSuccess).Invoke(Value);
    }

}