using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    internal static partial class _internalHelpers
    {
        public static Boolean IsSuccess<TResult>(TResult result)
            where TResult : IResult
            => result.Overall?.Equals(true) ?? false;

        public static Boolean IsFailure<TResult>(TResult result)
            where TResult : IResult
            => result.Overall?.Equals(false) ?? false;

        public static Boolean IsUnknown<TResult>(TResult result)
            where TResult : IResult
            => !result.Overall.HasValue;

        public static Boolean IsNotSuccess<TResult>(TResult result)
            where TResult : IResult
            => !result.Overall.HasValue || result.Overall.Equals(false);

    }
}
