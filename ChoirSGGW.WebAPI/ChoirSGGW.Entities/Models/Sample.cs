using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models
{
    [Table("Samples")]
    public class Sample : BasicModel
    {
        [Column("ClotheType")]
        public ClotheTypes ClotheType { get; set; }
    }
}
