using System;

namespace JasonPereira84.Result
{
    public partial class Result
    {
        public String AsString(
            Func<String> onSuccess,
            Func<String> onFailure,
            Func<String> onUnknown)
            => Do(
                onSuccess: () => onSuccess(),
                onFailure: () => onFailure(),
                onUnknown: () => onUnknown());

        public String AsString(
            String onSuccess,
            String onFailure,
            String onUnknown)
            => Do(
                onSuccess: () => onSuccess,
                onFailure: () => onFailure,
                onUnknown: () => onUnknown);

        public String AsString()
            => AsString("Success", "Failure", "Unknown");
    }

    public partial class Result<TValue>
    {
        public String AsString(
            Func<TValue, String> onSuccess,
#pragma warning disable IDE0060 // Remove unused parameter
            Func<TValue, String> onFailure,
            Func<TValue, String> onUnknown)
#pragma warning restore IDE0060 // Remove unused parameter
            => Do(
                onSuccess: (v) => onSuccess(v),
                onFailure: (v) => onSuccess(v),
                onUnknown: (v) => onSuccess(v));
	}

    public partial class Result<TValue, TError>
    {
        public String AsString(
            Func<TValue, TError, String> onSuccess,
            Func<TValue, TError, String> onFailure,
            Func<TValue, TError, String> onUnknown)
            => Do(
                onSuccess: (v, e) => onSuccess(v, e),
                onFailure: (v, e) => onFailure(v, e),
                onUnknown: (v, e) => onUnknown(v, e));

		public String AsString(
	        Func<TError, String> onSuccess,
	        Func<TError, String> onFailure,
	        Func<TError, String> onUnknown)
	        => Do(
		        onSuccess: (v, e) => onSuccess(e),
		        onFailure: (v, e) => onFailure(e),
		        onUnknown: (v, e) => onUnknown(e));
	}
}