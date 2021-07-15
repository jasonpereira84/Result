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
            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onFailure, Func<TError, TValue, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                        : _internalHelpers.IsFailure(result) ? onFailure
                            : _internalHelpers.FlipInvoke(onSuccess)).Invoke(result.Error, result.Value);
            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onFailure, Func<TError, TValue, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, _internalHelpers.SingleInvoke<TValue, TError, TResultOut>(onSuccess), onFailure, onUnknown);
            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onFailure), _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onUnknown));
            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onFailure), _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onUnknown));
            public static TResultOut Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TErrorOut, TValueOut>
                => Map<TError, TValue, TResult, TErrorOut, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);


            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onFailure, Func<TError, TValue, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => (_internalHelpers.IsUnknown(result) ? onUnknown
                        : _internalHelpers.IsFailure(result) ? onFailure
                            : _internalHelpers.FlipInvoke(onSuccess)).Invoke(result.Error, result.Value);
            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onFailure, Func<TError, TValue, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, _internalHelpers.SingleInvoke<TValue, TError, TResultOut>(onSuccess), onFailure, onUnknown);
            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TValue, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onFailure), _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onUnknown));
            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);

            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TResultOut> onFailure, Func<TError, TResultOut> onUnknown)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onFailure), _internalHelpers.SingleInvoke<TError, TValue, TResultOut>(onUnknown));
            public static TResultOut Map<TError, TValue, TResult, TValueOut, TResultOut>(this TResult result,
                Func<TValue, TError, TResultOut> onSuccess, Func<TError, TResultOut> onNotSuccess)
                where TResult : IResult<TError, TValue>
                where TResultOut : IResult<TError, TValueOut>
                => Map<TError, TValue, TResult, TError, TValueOut, TResultOut>(result, onSuccess, onNotSuccess, onNotSuccess);
        }
    }
}