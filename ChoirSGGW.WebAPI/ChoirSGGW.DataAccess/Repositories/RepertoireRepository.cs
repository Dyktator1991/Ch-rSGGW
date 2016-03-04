using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories
{
    public class RepertoireRepository : IRepertoireRepository
    {
        readonly IChoirContext context;

        public RepertoireRepository(IChoirContext context)
        {
            this.context = context;
        }
    }
}
