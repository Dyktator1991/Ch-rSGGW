using ChoirSGGW.Domain.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models
{
    public class SongNoteDTO : VisibilityModelDTO
    {
        public SongNoteDTO()
        {
            Notes = new List<PhotoDTO>();
        }

        public string SongName { get; set; }
        public PhotoDTO MainPhoto { get; set; }
        public List<PhotoDTO> Notes{ get; set; }
    }
}
