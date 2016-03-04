﻿using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.TypesRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories.TypesRepository
{
    public class TopicalityTypeRepository : ITopicalityTypeRepository
    {
        readonly IChoirContext context;

        public TopicalityTypeRepository(IChoirContext context)
        {
            this.context = context;
        }
    }
}
