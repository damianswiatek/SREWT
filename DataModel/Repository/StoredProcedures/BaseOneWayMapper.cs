using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public abstract class BaseOneWayMapper<TFrom, TTo>
        where TFrom : class
        where TTo : IMappableDTO
    {
        public bool Map(TFrom source, TTo target)
        {
            if (source == null || target == null)
                return false;
            MapCore(source, target);
            return true;
        }

        protected abstract void MapCore(TFrom source, TTo target);
    }
}
