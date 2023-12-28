namespace WebApiDemo.Helpers.Exceptions
{
    public class NotFoundException : CommonException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
