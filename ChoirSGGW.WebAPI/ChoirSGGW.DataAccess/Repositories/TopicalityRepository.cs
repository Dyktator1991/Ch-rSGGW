﻿using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories
{
    public class TopicalityRepository : ITopicalityRepository
    {
        readonly IChoirContext context;

        public TopicalityRepository(IChoirContext context)
        {
            this.context = context;
        }
    }
}
