﻿using ChoirSGGW.Domain.Models.BasicModels;
using ChoirSGGW.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Models
{
    public class SampleDTO : VisibilityModelDTO
    {
        public ClotheTypesDTO ClotheType { get; set; }
        public int IsOpenToAll { get; set; }
    }
}
