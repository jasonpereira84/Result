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
            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TError, TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                        : _internalHelpers.IsFailure(result) ? onFailure
                            : onSuccess).Invoke(result.Error);
            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TError, TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onFailure, onUnknown);
            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TResultOut> onFailure, Func<TResultOut> onUnknown)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onFailure, onUnknown);
            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TResultOut> onSuccess, Func<TResultOut> onNotSuccess)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TError, TResultOut> onSuccess, Func<TResultOut> onFailure, Func<TResultOut> onUnknown)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onFailure, onUnknown);
            public static TResultOut Map<TError, TResult, TErrorOut, TResultOut>(this TResult result,
                Func<TError, TResultOut> onSuccess, Func<TResultOut> onNotSuccess)
                where TResult : IResult<TError>
                where TResultOut : IResult<TErrorOut>
                => Map<TError, TResult, TErrorOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

        }
    }
}