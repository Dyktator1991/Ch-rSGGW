using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories
{
    public class SongNoteRepository : ISongNoteRepository
    {
        readonly IChoirContext context;

        public SongNoteRepository(IChoirContext context)
        {
            this.context = context;
        }
    }
}
