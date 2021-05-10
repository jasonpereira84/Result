using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    namespace Extensions
    {
        public static partial class Result
        {
            public static TReturn If<TResult, TReturn>(this TResult result,
               Func<TReturn> onSuccess,
               Func<TReturn> onFailure,
               Func<TReturn> onUnknown)
               where TResult : IResult
               => (_internalHelpers.IsUnknown(result) ? onUnknown
                   : _internalHelpers.IsFailure(result) ? onFailure
                       : onSuccess).Invoke();

            public static void If<TResult>(this TResult result,
                Action onSuccess,
                Action onFailure,
                Action onUnknown)
                where TResult : IResult
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : onSuccess)?.Invoke();

        }
    }
}
