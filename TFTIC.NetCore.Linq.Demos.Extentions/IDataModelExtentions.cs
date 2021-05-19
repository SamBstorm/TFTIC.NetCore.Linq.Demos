using System;
using System.Collections.Generic;
using System.Text;
using TFTIC.NetCore.Linq.Demos.Models.Interfaces;

namespace TFTIC.NetCore.Linq.Demos.Extentions
{
    public static class IDataModelExtentions
    {
        public static string GetId<TId>(this IDataModel<TId> dataModel)
        {
            return dataModel.Id.ToString();
        }
    }
}
