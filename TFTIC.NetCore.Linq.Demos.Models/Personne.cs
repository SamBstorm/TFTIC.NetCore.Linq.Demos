using System;
using TFTIC.NetCore.Linq.Demos.Models.Interfaces;

namespace TFTIC.NetCore.Linq.Demos.Models
{
    public sealed class Personne : IDataModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
