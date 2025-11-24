using System;

namespace JasonPereira84.Result
{
    public partial class ResultException<TException, TValue> : Exception
        where TException : Exception
    {
        public String AsString(
            String onSuccess,
            String onFailure,
            String onUnknown)
            => If(
                onSuccess: (e, v) => onSuccess,
                onFailure: (e, v) => onFailure,
                onUnknown: (e, v) => onUnknown);

        public String AsString()
            => AsString("Success", "Failure", "Unknown");
    }

}