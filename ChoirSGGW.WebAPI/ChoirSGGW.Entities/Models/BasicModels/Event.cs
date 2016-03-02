using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.BasicModels
{
    public abstract class Event : VisibilityModel
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public Photo MainPhoto { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Place { get; set; }
    }
}
