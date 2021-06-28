using System;

namespace _07JP27.Switchbot.Exceptions
{
    public class ServiceException: Exception
    {
        public ServiceException(string message)
            : base(message)
        {
        }
    }
}
