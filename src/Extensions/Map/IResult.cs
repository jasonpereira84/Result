using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    namespace Extensions
    {
        using Internal;

        public static partial class Result
        {
            public static TResultOut Map<TResult, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TResultOut> onFailure, Func<TResultOut> onUnknown)
                where TResult : IResult
                where TResultOut : IResult
                => (Helpers.IsUnknown(result) ? onUnknown
                        : Helpers.IsFailure(result) ? onFailure
                            : onSuccess).Invoke();
            public static TResultOut Map<TResult, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TResultOut> onNotSuccess)
                where TResult : IResult
                where TResultOut : IResult
                => Map(result, onSuccess, onNotSuccess, onNotSuccess);

        }
    }
}