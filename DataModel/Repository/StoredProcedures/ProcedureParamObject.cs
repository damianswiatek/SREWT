using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public class ProcedureParamObject
    {
        public string ParamName { get; set; }
        public object Data { get; set; }
        public SqlDbType Type { get; set; }

        public ProcedureParamObject(string paramName, object data, SqlDbType type)
        {
            this.ParamName = paramName;
            this.Data = data;
            this.Type = type;
        }
    }
}
