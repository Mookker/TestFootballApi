using System;

namespace TestFootballApi.Core.Exceptions
{
    /// <summary>
    /// Custom exception for forbidden actions.
    /// </summary>
    /// <seealso cref="System.UnauthorizedAccessException" />
    public class ForbiddenActionException : UnauthorizedAccessException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenActionException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ForbiddenActionException(string message) : base(message)
        {
        }
    }
}
