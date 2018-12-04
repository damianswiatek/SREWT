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
            set { }
        }
        #endregion

        #region Constructors
        public ServiceResult(T result)
        {
            this.Result = result;
            this.Messages = new List<ServiceMessage>();
        }

        public ServiceResult(T result, Boolean IsSuccess)
        {
            this.Result = result;
            this.IsSuccess = IsSuccess && this.Messages.Where(m => m.Type == ServiceMessageType.Error).Count() == 0;
        }
        #endregion

        #region Methods
        public ServiceResult<T> AddError(string sourceServiceName, string sourceMethod, ServiceMessageType type, string messageText, Exception exception = null)
        {
            this.Messages.Add(new ServiceMessage(sourceServiceName, sourceMethod, type, messageText, exception));
            return this;
        }
        #endregion
    }
}
