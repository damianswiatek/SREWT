using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public abstract class ProcedureBase : IProcedure
    {
        protected int? _timeout = null;

        public abstract IProcedure Initialize(params ProcedureParamObject[] list);
        public abstract IProcedure Initialize(params object[] list);
        public abstract IProcedure Initialize(params KeyValuePair<string, object>[] list);
        public abstract ProcedureResult Execute();
        public abstract IProcedure OutputParameters(params string[] list);
        public abstract IProcedure ReturnParameter(string parameter);
        public IProcedure SetCommandTimeout(int timeout)
        {
            _timeout = timeout;
            return this;
        }
    }
}
