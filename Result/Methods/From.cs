using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result
    {
        public static Result From(Boolean? overall = null, String error = null) => new Result(overall, error);

        public static Result FromUnknown(String error = null) => From(null, error);

        public static Result FromFailure(String error = null) => From(false, error);

        public static Result FromSuccess(String error = null) => From(true, error);
    }

    public partial struct Result<TValue>
    {
        public static Result<TValue> From(Boolean? overall = null, String error = null, TValue value = default(TValue)) => new Result<TValue>(overall, error, value);

        public static Result<TValue> FromUnknown(String error = null, TValue value = default(TValue)) => From(null, error, value);

        public static Result<TValue> FromFailure(String error = null, TValue value = default(TValue)) => From(false, error, value);

        public static Result<TValue> FromSuccess(TValue value, String error = null) => From(true, error, value);
    }

    public partial struct Result<TError, TValue>
    {
        public static Result<TError, TValue> From(Boolean? overall = null, TError error = default(TError), TValue value = default(TValue)) => new Result<TError, TValue>(overall, error, value);

        public static Result<TError, TValue> FromUnknown(TError error, TValue value = default(TValue)) => From(null, error, value);

        public static Result<TError, TValue> FromFailure(TError error, TValue value = default(TValue)) => From(false, error, value);

        public static Result<TError, TValue> FromSuccess(TValue value, TError error = default(TError)) => From(true, error, value);
    }
}
