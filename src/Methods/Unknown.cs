using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result
    {
        public static Result Unknown => new Result();
    }

    public partial struct Result<TValue>
    {
        public static Result<TValue> Unknown => new Result<TValue>();
    }

    public partial struct Result<TError, TValue>
    {
        public static Result<TError, TValue> Unknown => new Result<TError, TValue>();
    }
}
