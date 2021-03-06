using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;

namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a test method exceeds the given timeout value
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
    [Serializable]
    public class TimeoutException : AssertException
    {
        /// <summary>
        /// Creates a new instance of the <see cref="TimeoutException"/> class.
        /// </summary>
        /// <param name="timeout">The timeout value, in milliseconds</param>
        public TimeoutException(long timeout)
            : base(String.Format(CultureInfo.CurrentCulture, "Test execution time exceeded: {0}ms", timeout)) { }

        /// <inheritdoc/>
        protected TimeoutException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}