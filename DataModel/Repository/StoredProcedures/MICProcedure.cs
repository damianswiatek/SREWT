using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public class MICProcedure : SqlProcedure
    {
        public MICProcedure(string name) : base(name)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["myDB"]?.ConnectionString;
        }
    }
}
