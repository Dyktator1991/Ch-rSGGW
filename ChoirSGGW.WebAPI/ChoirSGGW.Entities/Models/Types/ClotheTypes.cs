using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Enums;
using ChoirSGGW.Entities.Models.BasicModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models.Types
{
    [Table("ClothesTypes")]
    public class ClotheTypes : BasicModel
    {
        public ClotheTypes(string clotheType)
        {
            this.ClotheType = clotheType;
        }

        public string ClotheType { get; set; }
    }
}
