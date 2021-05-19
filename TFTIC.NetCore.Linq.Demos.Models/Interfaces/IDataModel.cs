using System;
using System.Collections.Generic;
using System.Text;

namespace TFTIC.NetCore.Linq.Demos.Models.Interfaces
{
    public interface IDataModel<TId>
    {
        public TId Id { get; }
    }
}
