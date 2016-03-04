using ChoirSGGW.Domain.Models.BasicModels;
using ChoirSGGW.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models
{
    public class TopicalityDTO : EventDTO
    {
        public TopicalityDTO()
        {
            Photos = new List<PhotoDTO>();
        }

        public List<PhotoDTO> Photos { get; set; }
        public TopicalityTypeDTO Type { get; set; }
    }
}
