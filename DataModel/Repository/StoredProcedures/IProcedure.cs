using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public interface IProcedure
    {
        IProcedure Initialize(params ProcedureParamObject[] list);
        IProcedure Initialize(params object[] list);
        IProcedure Initialize(params KeyValuePair<string, object>[] list);
        ProcedureResult Execute();
        IProcedure OutputParameters(params string[] list);
        IProcedure ReturnParameter(string parameter);
        IProcedure SetCommandTimeout(int timeout);
    }
}
