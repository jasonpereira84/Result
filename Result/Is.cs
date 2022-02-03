using System;

namespace JasonPereira84.Result
{
    public partial struct Result<TError, TValue>
    {
        public Boolean NotIsUnknown
            => Overall.HasValue;
        public Boolean IsUnknown
            => !NotIsUnknown;

        public Boolean NotIsFailure
            => IsUnknown || Overall.Value == true;
        public Boolean IsFailure
            => !NotIsFailure;

        public Boolean NotIsSuccess
            => IsUnknown || Overall.Value == false;
        public Boolean IsSuccess
            => !NotIsSuccess;
    }

}