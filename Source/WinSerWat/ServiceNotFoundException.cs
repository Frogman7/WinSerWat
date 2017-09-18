using System;

namespace WinSerWat
{
    public class ServiceNotFoundException : Exception
    {
        private const string ExceptionMessage = "Windows Service '{0}' could not be found, please verify that it is installed";

        public string ServiceName { get; }

        public ServiceNotFoundException(string serviceName) : base(string.Format(ExceptionMessage, serviceName))
        {
            this.ServiceName = serviceName;
        }
    }
}
