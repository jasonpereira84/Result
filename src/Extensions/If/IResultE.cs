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
            public static TReturn If<TError, TResult, TReturn>(this TResult result,
               Func<TError, TReturn> onSuccess,
               Func<TError, TReturn> onFailure,
               Func<TError, TReturn> onUnknown)
               where TResult : IResult<TError>
               => (Helpers.IsUnknown(result) ? onUnknown
                   : Helpers.IsFailure(result) ? onFailure
                       : onSuccess).Invoke(result.Error);

            public static void If<TError, TResult>(this TResult result,
                Action<TError> onSuccess,
                Action<TError> onFailure,
                Action<TError> onUnknown)
                where TResult : IResult<TError>
                => (Helpers.IsUnknown(result) ? onUnknown
                    : Helpers.IsFailure(result) ? onFailure
                        : onSuccess)?.Invoke(result.Error);

            public static TReturn If<TError, TResult, TReturn>(this TResult result,
                Func<TReturn> onSuccess,
                Func<TReturn> onFailure,
                Func<TReturn> onUnknown)
                where TResult : IResult<TError>
                => (Helpers.IsUnknown(result) ? onUnknown
                    : Helpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke();

            public static void If<TError, TResult>(this TResult result,
                Action onSuccess,
                Action onFailure,
                Action onUnknown)
                where TResult : IResult<TError>
                => (Helpers.IsUnknown(result) ? onUnknown
                    : Helpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke();
        }
    }
}
