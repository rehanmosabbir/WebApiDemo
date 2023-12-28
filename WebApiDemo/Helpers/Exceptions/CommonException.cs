using System.Globalization;

namespace WebApiDemo.Helpers.Exceptions
{
    public class CommonException : Exception
    {
        public CommonException() : base() { }

        public CommonException(string message) : base(message) { }

        public CommonException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
