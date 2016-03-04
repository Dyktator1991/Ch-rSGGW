using ChoirSGGW.Domain.Models.BasicModels;
using ChoirSGGW.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models
{
    class ConcertDTO : EventDTO
    {
        public ConcertDTO()
        {
            Members = new List<UserDTO>();
            Photos = new List<PhotoDTO>();
        }

        public string ConcertUrl { get; set; }
        public List<UserDTO> Members { get; set; }
        public List<PhotoDTO> Photos { get; set; }
        public ClotheTypesDTO ClotheType { get; set; }
    }
}
