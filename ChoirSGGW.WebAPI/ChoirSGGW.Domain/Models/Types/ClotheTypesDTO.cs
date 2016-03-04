using ChoirSGGW.Domain.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models.Types
{
    public class ClotheTypesDTO : BasicModelDTO
    {
        public ClotheTypesDTO(string clotheType)
        {
            this.ClotheType = clotheType;
        }

        public string ClotheType { get; set; }
    }
}
