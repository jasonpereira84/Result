using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result : IResult<String>
    {
        public Boolean? Overall { get; private set; }

        public String Error { get; private set; }

        public Result(Boolean? overall, String error)
        {
            Error = error;
            Overall = overall;
        }
    }

    public partial struct Result<TValue> : IResult<String, TValue>
    {
        public Boolean? Overall { get; private set; }

        public String Error { get; private set; }

        public TValue Value { get; private set; }

        public Result(Boolean? overall, String error, TValue value)
        {
            Error = error;
            Value = value;
            Overall = overall;
        }
    }

    public partial struct Result<TError, TValue> : IResult<TError, TValue>
    {
        public Boolean? Overall { get; private set; }

        public TError Error { get; private set; }

        public TValue Value { get; private set; }

        public Result(Boolean? overall, TError error, TValue value)
        {
            Error = error;
            Value = value;
            Overall = overall;
        }
    }
}