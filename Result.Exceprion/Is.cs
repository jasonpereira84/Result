using System;

namespace JasonPereira84.Result
{
    public partial class ResultException<TException, TValue> : Exception
        where TException : Exception
    {
        public Boolean NotIsUnknown
            => Overall.HasValue;
        public Boolean IsUnknown
            => !NotIsUnknown;

        public Boolean NotIsFailure
#pragma warning disable CS8629 // Nullable value type may be null.
            => IsUnknown || Overall.Value == true;
#pragma warning restore CS8629 // Nullable value type may be null.
        public Boolean IsFailure
            => !NotIsFailure;

        public Boolean NotIsSuccess
#pragma warning disable CS8629 // Nullable value type may be null.
            => IsUnknown || Overall.Value == false;
#pragma warning restore CS8629 // Nullable value type may be null.
        public Boolean IsSuccess
            => !NotIsSuccess;
    }

}