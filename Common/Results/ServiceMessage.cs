using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Results
{
    public class ServiceMessage
    {        
        public Exception Exception { get; }
      
        public string MessageKey { get; }
        
        public string MessageText { get; }      
       
        public string SourceMethod { get; }
        
        public string SourceServiceName { get; }
      
        public ServiceMessageType Type { get; }

        public ServiceMessage(string sourceServiceName, string sourceMethod, ServiceMessageType type, string messageKey, string messageText, Exception exception = null)
        {
            this.SourceServiceName = sourceServiceName;
            this.SourceMethod = sourceMethod;
            this.Type = type;
            this.MessageKey = messageKey;
            this.MessageText = messageText;
            this.Exception = exception;
        }
    }

    public enum ServiceMessageType
    {
        //
        // Summary:
        //     Info = 1
        Info = 1,
        //
        // Summary:
        //     Warning = 2
        Warning = 2,
        //
        // Summary:
        //     Error = 3
        Error = 3
    }
}
