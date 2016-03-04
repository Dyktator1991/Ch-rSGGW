using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class TopicalityService : ITopicalityService
    {
        readonly ITopicalityRepository TopicalityRepository;

        public TopicalityService(ITopicalityRepository TopicalityRepository)
        {
            this.TopicalityRepository = TopicalityRepository;
        }
    }
}
