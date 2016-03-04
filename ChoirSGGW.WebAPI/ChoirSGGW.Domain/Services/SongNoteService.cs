using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class SongNoteService : ISongNoteService
    {
        readonly ISongNoteRepository songNoteRepository;

        public SongNoteService(ISongNoteRepository songNoteRepository)
        {
            this.songNoteRepository = songNoteRepository;
        }
    }
}
