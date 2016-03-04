﻿using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.TypesRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories.TypesRepository
{
    public class ClotheTypesRepository : IClotheTypesRepository
    {
        readonly IChoirContext context;

        public ClotheTypesRepository(IChoirContext context)
        {
            this.context = context;
        }
    }
}
