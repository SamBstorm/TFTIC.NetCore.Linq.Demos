using System;
using System.Collections.Generic;
using System.Text;
using TFTIC.NetCore.Linq.Demos.Models.Interfaces;

namespace TFTIC.NetCore.Linq.Demos.Models
{
    public sealed class Item : IDataModel<Guid>
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public Item()
        {
            Id = Guid.NewGuid(); //Generated Unique Identifier = Hexadecimal de 32 caractères
        }
    }
}
