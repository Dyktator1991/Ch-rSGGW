using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Generic;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories
{
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        readonly IChoirContext context;

        public PhotoRepository(IChoirContext context, DbContext dbcontext)
            : base(dbcontext)
        {
            this.context = context;
        }
    }
}
