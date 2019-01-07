using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public static class KVPExtension
    {
        public static KeyValuePair<string, object> PairWith(this string key, object value)
        {
            return new KeyValuePair<string, object>(key, value);
        }
    }
}
