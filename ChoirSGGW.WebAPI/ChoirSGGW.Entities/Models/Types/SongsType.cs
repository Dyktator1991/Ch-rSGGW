using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.Types
{
    [Table("SongsTypes")]
    public class SongsType : BasicModel
    {
        public SongsType(string songType)
        {
            this.SongType = songType;
        }

        public string SongType { get; set; }
    }
}
