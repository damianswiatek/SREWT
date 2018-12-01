using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Results
{
    public class ServiceResult<T>
    {
        #region Properties
        public T Result { get; set; }
        public List<ServiceMessage> Messages { get; }
        #endregion

        #region Deducted Properties
        public bool IsSuccess
        {
            get
            {
                return this.Messages.Where(m => m.Type == ServiceMessageType.Error).Count() == 0;
            }
        }
        public List<ServiceMessage> Errors
        {
            get
            {
                return this.Messages.Where(m => m.Type == ServiceMessageType.Error).ToList();
            }
        }
        #endregion

        #region Constructors
        public ServiceResult(T result)
        {
            this.Result = result;
            this.Messages = new List<ServiceMessage>();
        }
        #endregion

        #region Methods

        public void AddError(string sourceServiceName, string sourceMethod, string messageKey, string messageText, Exception exception = null)
        {
            this.Messages.Add(new ServiceMessage(sourceServiceName, sourceMethod, ServiceMessageType.Error, messageKey, messageText, exception));
        }
        #endregion
    }
}
