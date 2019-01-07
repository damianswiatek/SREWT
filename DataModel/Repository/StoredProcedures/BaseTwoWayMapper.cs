using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public abstract class BaseTwoWayMapper<TFrom, TTo> : BaseOneWayMapper<TFrom, TTo>
        where TFrom : class
        where TTo : IMappableDTO
    {
        public bool Map(TTo source, TFrom target)
        {
            if (source == null || target == null)
                return false;
            MapCore(source, target);
            return true;
        }

        protected abstract void MapCore(TTo source, TFrom target);
    }
}
