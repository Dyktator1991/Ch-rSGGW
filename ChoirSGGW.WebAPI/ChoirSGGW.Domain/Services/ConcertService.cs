using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class ConcertService : IConcertService
    {
        readonly IConcertRepository concertRepository;

        public ConcertService(IConcertRepository concertRepository)
        {
            this.concertRepository = concertRepository;
        }
    }
}
