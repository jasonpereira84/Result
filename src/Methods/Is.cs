using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    using Internal;

    public partial struct Result
    {
        public Boolean IsSuccess => Helpers.IsSuccess(this);

        public Boolean IsFailure => Helpers.IsFailure(this);

        public Boolean IsUnknown => Helpers.IsUnknown(this);

        public Boolean IsNotSuccess => Helpers.IsNotSuccess(this);
    }

    public partial struct Result<TValue>
    {
        public Boolean IsSuccess => Helpers.IsSuccess(this);

        public Boolean IsFailure => Helpers.IsFailure(this);

        public Boolean IsUnknown => Helpers.IsUnknown(this);

        public Boolean IsNotSuccess => Helpers.IsNotSuccess(this);
    }

    public partial struct Result<TError, TValue>
    {
        public Boolean IsSuccess => Helpers.IsSuccess(this);

        public Boolean IsFailure => Helpers.IsFailure(this);

        public Boolean IsUnknown => Helpers.IsUnknown(this);

        public Boolean IsNotSuccess => Helpers.IsNotSuccess(this);
    }
}
