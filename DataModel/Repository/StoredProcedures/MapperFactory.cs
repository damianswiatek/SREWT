
using DataModel.Repository.StoredProcedures.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public static class MapperFactory
    {
        private static readonly List<Type> _mapTypes = new List<Type>
        {
            typeof(UserMap)
            ,typeof(UserDetailMap)
        };

        public static BaseTwoWayMapper<TFrom, TTo> GetTwoWayMap<TFrom, TTo>()
            where TFrom : class
            where TTo : IMappableDTO
        {
            var mapType = _mapTypes.FirstOrDefault(t => typeof(BaseTwoWayMapper<TFrom, TTo>).IsAssignableFrom(t));
            if (mapType == null)
                throw new ArgumentException("Cannot find mapper from " + typeof(TFrom) + " to " + typeof(TTo));
            return Activator.CreateInstance(mapType) as BaseTwoWayMapper<TFrom, TTo>;
        }

        public static BaseOneWayMapper<TFrom, TTo> GetOneWayMap<TFrom, TTo>()
            where TFrom : class
            where TTo : IMappableDTO
        {
            var mapType = _mapTypes.FirstOrDefault(t => typeof(BaseOneWayMapper<TFrom, TTo>).IsAssignableFrom(t));
            if (mapType == null)
                throw new ArgumentException("Cannot find mapper from " + typeof(TFrom) + " to " + typeof(TTo));
            var map = Activator.CreateInstance(mapType) as BaseOneWayMapper<TFrom, TTo>;

            return map;
        }


    }
}
