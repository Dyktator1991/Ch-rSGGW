using ChoirSGGW.Domain.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models
{
    public class PhotoDTO : VisibilityModelDTO
    {
        public string PhotoName { get; set; } //photo name with extension. For example rower.jpg / samochod.png
        public string PhotoDescription { get; set; }
        public byte[] PhotoFileByte { get; set; }
    }
}
