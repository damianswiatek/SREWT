using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public class ProcedureResult
    {
        public List<Dictionary<string, object>> DataRows { get; private set; }
        public List<List<Dictionary<string, object>>> Results { get; private set; }
        public Dictionary<string, object> Parameters { get; private set; }


        public ProcedureResult()
        {
            DataRows = new List<Dictionary<string, object>>();
            Parameters = new Dictionary<string, object>();
            Results = new List<List<Dictionary<string, object>>>();
        }
    }
}
