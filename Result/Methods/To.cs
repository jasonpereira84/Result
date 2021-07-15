using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result
    {
        private Result to(Boolean overall, String error)
        {
            Overall = overall;
            Error = error;
            return this;
        }

        public Result ToFailure(String error = null) => to(false, error);

        public Result ToSuccess(String error = null) => to(true, error);
    }

    public partial struct Result<TValue>
    {
        private Result<TValue> to(Boolean overall, String error, TValue value)
        {
            Overall = overall;
            Error = error;
            Value = value;
            return this;
        }

        public Result<TValue> ToFailure(String error = null, TValue value = default(TValue)) => to(false, error, value);

        public Result<TValue> ToSuccess(TValue value, String error = null) => to(true, error, value);
    }

    public partial struct Result<TError, TValue>
    {
        private Result<TError, TValue> to(Boolean overall, TError error, TValue value)
        {
            Overall = overall;
            Error = error;
            Value = value;
            return this;
        }

        public Result<TError, TValue> ToFailure(TError error = default(TError), TValue value = default(TValue)) => to(false, error, value);

        public Result<TError, TValue> ToSuccess(TValue value, TError error = default(TError)) => to(true, error, value);
    }
}
