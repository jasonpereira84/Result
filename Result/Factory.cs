using System;

namespace JasonPereira84.Result
{
    public partial class Result
    {
        public static Result FromUnknown()
            => new(null);

        public static Result FromFailure()
            => new(false);

        public static Result FromSuccess()
            => new(true);
    }

    public partial class Result<TValue>
    {
        public static Result<TValue> FromUnknown(TValue value)
            => new(null, value);
        public new static Result<TValue> FromUnknown()
            => FromUnknown(default);

        public static Result<TValue> FromFailure(TValue value)
            => new(false, value);
        public new static Result<TValue> FromFailure()
            => FromFailure(default);

        public static Result<TValue> FromSuccess(TValue value)
            => new(true, value);
        private new static Result<TValue> FromSuccess()
            => FromSuccess(default);
    }

    public partial class Result<TValue, TError>
    {
        public static Result<TValue, TError> FromUnknown(TValue value, TError error)
            => new(null, value, error);
        public new static Result<TValue, TError> FromUnknown(TValue value)
            => FromUnknown(value, default);
        public static Result<TValue, TError> FromUnknown(TError error)
            => FromUnknown(default, error);
        public new static Result<TValue, TError> FromUnknown()
            => FromUnknown(default, default);

        public static Result<TValue, TError> FromFailure(TValue value, TError error)
            => new(false, value, error);
        public new static Result<TValue, TError> FromFailure(TValue value)
            => FromFailure(value, default);
        public static Result<TValue, TError> FromFailure(TError error)
            => FromFailure(default, error);
        private new static Result<TValue, TError> FromFailure()
            => FromFailure(default, default);

        public static Result<TValue, TError> FromSuccess(TValue value, TError error)
            => new(true, value, error);
        public new static Result<TValue, TError> FromSuccess(TValue value)
            => FromSuccess(value, default);
        private static Result<TValue, TError> FromSuccess(TError error)
            => FromSuccess(default, error);
        private new static Result<TValue, TError> FromSuccess()
            => FromSuccess(default, default);
    }

}