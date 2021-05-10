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
            public static TReturn If<TValue, TError, TResult, TReturn>(this TResult result,
                Func<TValue, TError, TReturn> onSuccess, 
                Func<TError, TValue, TReturn> onFailure, 
                Func<TError, TValue, TReturn> onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : _internalHelpers.FlipInvoke(onSuccess)).Invoke(result.Error, result.Value);

            public static void If<TValue, TError, TResult>(this TResult result,
                Action<TValue, TError> onSuccess, 
                Action<TError, TValue> onFailure, 
                Action<TError, TValue> onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : _internalHelpers.FlipInvoke(onSuccess))?.Invoke(result.Error, result.Value);

            public static TReturn If<TValue, TError, TResult, TReturn>(this TResult result,
                Func<TError, TReturn> onSuccess, 
                Func<TError, TReturn> onFailure, 
                Func<TError, TReturn> onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke(result.Error);

            public static void If<TValue, TError, TResult>(this TResult result,
                Action<TError> onSuccess,
                Action<TError> onFailure,
                Action<TError> onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke(result.Error);

            public static TReturn If<TValue, TError, TResult, TReturn>(this TResult result,
                Func<TReturn> onSuccess,
                Func<TReturn> onFailure,
                Func<TReturn> onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke();

            public static void If<TValue, TError, TResult>(this TResult result,
                Action onSuccess,
                Action onFailure,
                Action onUnknown)
                where TResult : IResult<TError, TValue>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                    : _internalHelpers.IsFailure(result) ? onFailure
                        : onSuccess).Invoke();
        }
    }
}
