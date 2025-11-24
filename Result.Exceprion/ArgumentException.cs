using JasonPereira84.Result;
using System;

namespace JasonPereira84.Result
{
    public class ResultArgumentException<TValue> : ResultException<ArgumentException, TValue>
    {
#pragma warning disable CS8601 // Possible null reference assignment.
        public ResultArgumentException(Nullable<Boolean> overall, ArgumentException argumentException, TValue value = default)
#pragma warning restore CS8601 // Possible null reference assignment.
            : base(overall, argumentException, value)
        {
        }

#pragma warning disable CS8601 // Possible null reference assignment.
        public ResultArgumentException(Nullable<Boolean> overall, String paramName, TValue value = default)
#pragma warning restore CS8601 // Possible null reference assignment.
            : base(overall, new ArgumentException($"There was an error with the value of '${paramName}'"), value)
        {
        }

#pragma warning disable CS8601 // Possible null reference assignment.
        public static ResultArgumentException<TValue> From(String paramName, TValue value = default, Exception? innerException = default)
#pragma warning restore CS8601 // Possible null reference assignment.
            => new ResultArgumentException<TValue>(false, paramName, value) { };

        public static ResultArgumentException<String> From(String paramName, String value, Exception? innerException = default)
            => new ResultArgumentException<String>(false, paramName, value) { };

        public static ResultArgumentException<TValue> FromNull(String paramName, Exception? innerException)
#pragma warning disable CS8604 // Possible null reference argument.
            => new ResultArgumentException<TValue>(false, new ArgumentException($"The value of '${paramName}' was NULL", innerException), default) { };
#pragma warning restore CS8604 // Possible null reference argument.

        public static ResultArgumentException<TValue> FromNotFoundInConfiguration(String paramName, TValue value, Exception? innerException)
            => new ResultArgumentException<TValue>(false, new ArgumentException($"'{paramName}' was not found in configuration", innerException), value) { };
    }

}