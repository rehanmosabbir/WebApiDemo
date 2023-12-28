namespace WebApiDemo.Helpers.Exceptions
{
    public class UnauthorizedAccessException : CommonException
    {
        public UnauthorizedAccessException(string message) : base(message)
        {
        }
    }
}
